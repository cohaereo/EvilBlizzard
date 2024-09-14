using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using EvilBlizzard;
using EvilBlizzard.Proto;
using EvilBlizzard.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var port = 1119;

        var serverCertificate = new X509Certificate2("bnetserver.p12", "123");

        var listener = new TcpListener(IPAddress.IPv6Any, port);
        listener.Server.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
        listener.Start();
        Console.WriteLine($"TLS Server is listening on port {port}");

        var services = new Dictionary<uint, Service>();
        foreach (var svc in new Service[]
                 {
                     new ConnectionService(),
                     new AuthenticationService(),
                     new SessionService(),
                     new FriendsService(),
                     new UserManagerService(),
                     new AccountService(),
                     new WhisperService(),
                     new ResourceService(),             
                     new ChannelMembershipService(),
                     new PresenceService()
                 })
        {
            var serviceHash = svc.GetType().GetCustomAttribute<ServiceAttribute>()?.ServiceHash;
            if (serviceHash == null)
                throw new ArgumentException($"Service {svc.GetType().Name} must have ServiceAttribute with ServiceHash");

            services[serviceHash.Value] = svc;
        }

        while (true)
        {
            var tcpClient = listener.AcceptTcpClient();
            var endpoint = tcpClient.Client.RemoteEndPoint as IPEndPoint;
            Console.WriteLine($"Client connected from {endpoint?.Address}:{endpoint.Port}");

            var networkStream = tcpClient.GetStream();
            var sslStream = new SslStream(networkStream, false);

            try
            {
                sslStream.AuthenticateAsServer(serverCertificate, false, true);
                Console.WriteLine("TLS handshake successful.");

                var client = new Client(sslStream);

                while (true)
                {
                    var frame = client.ReadRaw();
                    // Console.WriteLine(
                    //     $"Received {frame.Opcode} packet from client: {BitConverter.ToString(frame.Data)}");
                    if (frame.Opcode == WebSocketFrame.OpCode.Close)
                    {
                        var closeReason = (WebSocketFrame.StatusCode)BitConverter.ToUInt16(frame.Data[..2].Reverse().ToArray());
                        Console.WriteLine($"Closing connection with reason {closeReason}");
                        break;
                    }

                    var packet = new BgsMessage(frame.Data);
                    var context = new RequestContext(client, packet.Header);
                    // Console.WriteLine(
                    //     $"BGS Packet: service=0x{packet.Header.ServiceHash:X} method={packet.Header.MethodId}");

                    object? result;
                    if (services.TryGetValue(packet.Header.ServiceHash, out var service))
                    {
                        Console.WriteLine(
                            $"R{packet.Header.Token} Executing service method {service.GetType().Name}::{service.GetMethodName(packet.Header.MethodId) ?? "???"}");
                        result = service.Dispatch(packet.Header.MethodId, packet.MessageData, context);
                    }
                    else
                    {
                        // throw new Exception($"Unknown service hash=0x{packet.Header.ServiceHash:X} method={packet.Header.MethodId}");
                        Console.WriteLine($"Unknown service hash=0x{packet.Header.ServiceHash:X} method={packet.Header.MethodId}");
                        continue;
                    }

                    if (result != null)
                    {
                        var msg = BgsMessage.Create(254, packet.Header.ServiceHash, packet.Header.MethodId, result, packet.Header.Token);
                        msg.Header.Status = (uint)context.Error;
                        client.Send(msg);
                    }
                }

                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }
            finally
            {
                sslStream.Close();
            }
        }
    }
}