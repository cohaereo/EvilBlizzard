using System.Diagnostics;
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

    public static byte[] Read(Stream stream)
    {
        var header = new byte[2];
        stream.ReadExactly(header);

        Console.WriteLine($"Received header: {BitConverter.ToString(header)}");
        var fin = (header[0] & 0x80) != 0;
        var opcode = header[0] & 0xf; // bits 4-7
        Debug.Assert(opcode == 1 || opcode == 2, $"TODO: message opcode {(OpCode)opcode}");
        var masked = (header[1] & 0x80) != 0; // bit 8
        if (!masked)
            throw new SerializationException("Client messages must be masked");

        var payloadSize = header[1] & 0x7f; // bits 9-15
        if (payloadSize == 126)
        {
            var payloadSizeBytes = new byte[2];
            stream.ReadExactly(payloadSizeBytes);
            Console.WriteLine($"Received u16 payload size: {BitConverter.ToString(payloadSizeBytes)}");
            payloadSize = BitConverter.ToUInt16(payloadSizeBytes.Reverse().ToArray());
        }

        if (payloadSize == 127)
        {
            var payloadSizeBytes = new byte[8];
            stream.ReadExactly(payloadSizeBytes);
            Console.WriteLine($"Received u64 payload size: {BitConverter.ToString(payloadSizeBytes)}");
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

        return data;
    }

    public static void Write(Stream stream, byte[] data)
    {
        Console.WriteLine($"Writing packet data {BitConverter.ToString(data)}");

        var msg = new MemoryStream();
        Debug.Assert(data.Length <= 125, "TODO: large messages");
        msg.Write(new byte[]
        {
            0x80 | (byte)OpCode.Binary, // single packet binary
            Convert.ToByte(data.Length & 0x7f)
        });

        msg.Write(data);

        Console.WriteLine($"Response: {BitConverter.ToString(msg.ToArray())}");

        stream.Write(msg.ToArray());
    }
}