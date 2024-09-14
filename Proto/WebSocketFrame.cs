using System.Runtime.Serialization;

namespace EvilBlizzard.Proto;

public class WebSocketFrame
{
    public enum OpCode
    {
        Continuation = 0,
        Text = 1,
        Binary = 2,
        Close = 8,
        Ping = 9,
        Pong = 10
    }

    public enum StatusCode
    {
        /// <summary>Normal closure.</summary>
        NormalClosure = 1000,

        /// <summary>Going away (e.g. browser tab closed).</summary>
        GoingAway = 1001,

        /// <summary>Protocol error.</summary>
        ProtocolError = 1002,

        /// <summary>Unsupported data (e.g. endpoint only understands text but received binary).</summary>
        UnsupportedData = 1003,

        /// <summary>Reserved for future usage</summary>
        Reserved1004 = 1004,

        /// <summary>No code received.</summary>
        NoCodeReceived = 1005,

        /// <summary>Connection closed abnormally (closing handshake did not occur).</summary>
        AbnormalClosure = 1006,

        /// <summary>Invalid payload data (e.g. non UTF-8 data in a text message).</summary>
        InvalidPayload = 1007,

        /// <summary>Policy violated.</summary>
        PolicyViolated = 1008,

        /// <summary>Message too big.</summary>
        MessageTooBig = 1009,

        /// <summary>Unsupported extension. The client should write the extensions it expected the server to support in the payload.</summary>
        UnsupportedExtension = 1010,

        /// <summary>Internal server error.</summary>
        InternalError = 1011,

        /// <summary>TLS handshake failure.</summary>
        TlsHandshakeFailure = 1015
    }

    public byte[] Data;
    public OpCode Opcode;

    public WebSocketFrame(byte[] data, OpCode opcode)
    {
        Data = data;
        Opcode = opcode;
    }

    public static WebSocketFrame Read(Stream stream)
    {
        var header = new byte[2];
        stream.ReadExactly(header);

        var fin = (header[0] & 0x80) != 0;
        var opcode = header[0] & 0xf; // bits 4-7
        var masked = (header[1] & 0x80) != 0; // bit 8
        if (!masked)
            throw new SerializationException("Client messages must be masked");

        var payloadSize = header[1] & 0x7f; // bits 9-15
        if (payloadSize == 126)
        {
            var payloadSizeBytes = new byte[2];
            stream.ReadExactly(payloadSizeBytes);
            payloadSize = BitConverter.ToUInt16(payloadSizeBytes.Reverse().ToArray());
        }

        if (payloadSize == 127)
        {
            var payloadSizeBytes = new byte[8];
            stream.ReadExactly(payloadSizeBytes);
            payloadSize = (int)BitConverter.ToUInt64(payloadSizeBytes.Reverse().ToArray());
        }

        if (!fin)
            throw new NotImplementedException("fragmented messages");
        var maskingKey = new byte[4];
        var data = new byte[payloadSize];
        stream.ReadExactly(maskingKey);
        stream.Read(data, 0, payloadSize);
        for (var i = 0; i < payloadSize; i++)
            data[i] = (byte)(data[i] ^ maskingKey[i % 4]);

        return new WebSocketFrame(data, (OpCode)opcode);
    }

    public static void Write(Stream stream, byte[] data)
    {
        var msg = new MemoryStream();
        var length = data.Length <= 125 ? data.Length : data.Length > ushort.MaxValue ? 127 : 126;
        msg.Write(new byte[]
        {
            0x80 | (byte)OpCode.Binary, // single packet binary
            Convert.ToByte(length)
        });

        if (length == 126) msg.Write(BitConverter.GetBytes((ushort)data.Length).Reverse().ToArray());
        if (length == 127) msg.Write(BitConverter.GetBytes((ulong)data.Length).Reverse().ToArray());

        msg.Write(data);

        stream.Write(msg.ToArray());
    }
}