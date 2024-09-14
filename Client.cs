using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using EvilBlizzard.Proto;

namespace EvilBlizzard;

public class Client
{
    private readonly SslStream _stream;

    public Client(SslStream stream)
    {
        _stream = stream;
        Handshake();
    }

    private void Handshake()
    {
        // Read the data sent by the client
        var buffer = new byte[4096];
        var bytesRead = _stream.Read(buffer, 0, buffer.Length);
        var str = Encoding.ASCII.GetString(buffer, 0, bytesRead);
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

        _stream.Write(Encoding.UTF8.GetBytes(switchProtocols));
        _stream.Flush();
        Console.WriteLine("Switched protocols HTTP => WS(S)");
    }

    public WebSocketFrame ReadRaw()
    {
        return WebSocketFrame.Read(_stream);
    }

    public void Send(BgsMessage message)
    {
        WebSocketFrame.Write(_stream, message.Serialize());
    }

    public void Close()
    {
        _stream.Close();
    }
}