using bgs.protocol;
using ProtoBuf;

namespace EvilBlizzard;

public class BgsMessage
{
    public BgsMessage(byte[] data)
    {
        HeaderLength = BitConverter.ToInt16(data[..2].Reverse().ToArray());
        var rawHeader = data[2..(2 + HeaderLength)];
        Header = Serializer.Deserialize<Header>(new ReadOnlySpan<byte>(rawHeader));
        MessageData = data[(2 + HeaderLength)..];
    }

    public BgsMessage()
    {
    }

    public int HeaderLength { get; set; }
    public Header Header { get; set; }
    public byte[] MessageData { get; set; }

    public static BgsMessage Create<T>(uint serviceId, uint serviceHash, uint methodId, T message, uint token)
    {
        var msgData = new MemoryStream();
        Serializer.Serialize(msgData, message);
        return new BgsMessage
        {
            Header = new Header
            {
                ServiceId = serviceId,
                MethodId = methodId,
                ServiceHash = serviceHash,
                Token = token
            },
            MessageData = msgData.ToArray()
        };
    }

    public byte[] Serialize()
    {
        var rawHeader = new MemoryStream();
        Serializer.Serialize(rawHeader, Header);
        return BitConverter.GetBytes(Convert.ToUInt16(rawHeader.Length)).Reverse()
            .Concat(rawHeader.ToArray())
            .Concat(MessageData).ToArray();
    }
}