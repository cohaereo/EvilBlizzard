using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using bgs.protocol;
using EvilBlizzard;
using EvilBlizzard.Proto;
using EvilBlizzard.Services;
using ProtoBuf;

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

        var services = new Dictionary<uint, IService>();
        foreach (var svc in new IService[]
                 {
                     new ConnectionService(),
                     new AuthenticationService()
                 })
        {
            var serviceHash = svc.GetType().GetCustomAttribute<ServiceAttribute>()?.ServiceHash;
            if (serviceHash == null)
                throw new ArgumentException($"Service {svc.GetType().Name} must have ServiceAttribute with ServiceHash");

            services[serviceHash.Value] = svc;
        }

        while (true)
        {
            var client = listener.AcceptTcpClient();
            var endpoint = client.Client.RemoteEndPoint as IPEndPoint;
            Console.WriteLine($"Client connected from {endpoint?.Address}:{endpoint.Port}");

            var networkStream = client.GetStream();
            var sslStream = new SslStream(networkStream, false);

            try
            {
                sslStream.AuthenticateAsServer(serverCertificate, false, true);

                Console.WriteLine("TLS handshake successful.");

                // Read the data sent by the client
                var buffer = new byte[4096];
                var bytesRead = sslStream.Read(buffer, 0, buffer.Length);
                var str = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Received {bytesRead} bytes from client: {str}");
                var nonceLine = str.Split("\r\n").First(x => x.StartsWith("Sec-WebSocket-Key"));
                var swk = Regex.Match(nonceLine, "Sec-WebSocket-Key: (.*)").Groups[1].Value.Trim();
                var swka = swk + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";
                var swkaSha1 = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(swka));
                var swkaSha1Base64 = Convert.ToBase64String(swkaSha1);


                var switchProtocols = $@"HTTP/1.1 101 Switching Protocols
Upgrade: websocket
Connection: Upgrade
Sec-WebSocket-Accept: {swkaSha1Base64}
Sec-WebSocket-Protocol: v1.rpc.battle.net

".ReplaceLineEndings("\r\n");

                sslStream.Write(Encoding.UTF8.GetBytes(switchProtocols));
                sslStream.Flush();
                Console.WriteLine("Switching protocols HTTP => WS(S)");

                while (true)
                {
                    var frame = WebSocketFrame.Read(sslStream);

                    Console.WriteLine(
                        $"Received {frame.Opcode} packet from client: {BitConverter.ToString(frame.Data)}");
                    if (frame.Opcode == WebSocketFrame.OpCode.Close)
                    {
                        var closeReason = (WebSocketFrame.StatusCode)BitConverter.ToUInt16(frame.Data[..2].Reverse().ToArray());
                        Console.WriteLine($"Closing connection with reason {closeReason}");
                        break;
                    }

                    var packet = new BgsPacket(frame.Data);
                    Console.WriteLine(
                        $"BGS Packet: service=0x{packet.Header.ServiceHash:X} method={packet.Header.MethodId}");

                    object? result;
                    if (services.TryGetValue(packet.Header.ServiceHash, out var service))
                        result = service.Dispatch(packet.Header.MethodId, packet.MessageData);
                    else
                        throw new Exception($"Unknown service: 0x{packet.Header.ServiceHash:X}");

                    if (result != null)
                    {
                        var msgData = new MemoryStream();
                        Serializer.Serialize(msgData, result);
                        var newPacket = new BgsPacket
                        {
                            Header = new Header
                            {
                                ServiceId = 254,
                                MethodId = packet.Header.MethodId,
                                ServiceHash = packet.Header.ServiceHash
                            },
                            MessageData = msgData.ToArray()
                        };

                        WebSocketFrame.Write(sslStream, newPacket.Serialize());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }
            finally
            {
                sslStream.Close();
                client.Close();
            }
        }
    }
}