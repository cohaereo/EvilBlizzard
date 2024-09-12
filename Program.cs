using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using bgs.protocol;
using bgs.protocol.connection.v1;
using EvilBlizzard;
using EvilBlizzard.Proto;
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

        while (true)
        {
            var client = listener.AcceptTcpClient();
            var endpoint = client.Client.RemoteEndPoint as IPEndPoint;
            Console.WriteLine($"Client connected from {endpoint.Address}:{endpoint.Port}");

            var networkStream = client.GetStream();
            var sslStream = new SslStream(networkStream, false);

            try
            {
                // Authenticate the server using the server's certificate
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

                // Console.WriteLine(
                //     $"respon: {BitConverter.ToString(Encoding.UTF8.GetBytes(switchProtocols))}");
                sslStream.Write(Encoding.UTF8.GetBytes(switchProtocols));
                sslStream.Flush();
                Console.WriteLine("Switching protocols HTTP => WS(S)");

                while (true)
                {
                    var data = WebSocketFrame.Read(sslStream);

                    Console.WriteLine(
                        $"Received {data.Length}  bytes from client: {BitConverter.ToString(data)}");
                    var packet = new BgsPacket(data);
                    Console.WriteLine(
                        $"BGS Packet: service=0x{packet.Header.ServiceHash:X} method={packet.Header.MethodId}");

                    switch (packet.Header.ServiceHash)
                    {
                        case 0x65446991:
                        case 0x69BDBFEF:
                            var unixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                            switch (packet.Header.MethodId)
                            {
                                case 1:
                                    var response = new ConnectResponse
                                    {
                                        ServerId = new ProcessId
                                        {
                                            Epoch = (uint)unixTime,
                                            Label = (uint)Environment.ProcessId
                                        },
                                        ServerTime = (uint)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
                                    };

                                    var msgData = new MemoryStream();
                                    Serializer.Serialize(msgData, response);
                                    var newPacket = new BgsPacket
                                    {
                                        Header = new Header
                                        {
                                            ServiceId = 254,
                                            MethodId = 1,
                                            ServiceHash = 0x65446991
                                        },
                                        MessageData = msgData.ToArray()
                                    };

                                    WebSocketFrame.Write(sslStream, newPacket.Serialize());

                                    break;
                                default:
                                    Console.WriteLine($"Unknown service method {packet.Header.MethodId}");
                                    break;
                            }

                            break;
                        default:
                            Console.WriteLine($"Unknown service hash: {packet.Header.ServiceHash:X}");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                sslStream.Close();
                client.Close();
            }
        }
    }
}