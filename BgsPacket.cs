using bgs.protocol;
using ProtoBuf;

namespace EvilBlizzard;

public class BgsPacket
{
    private static uint requestToken;

    public BgsPacket(byte[] data)
    {
        HeaderLength = BitConverter.ToInt16(data[..2].Reverse().ToArray());
        var rawHeader = data[2..(2 + HeaderLength)];
        Header = Serializer.Deserialize<Header>(new ReadOnlySpan<byte>(rawHeader));
        MessageData = data[(2 + HeaderLength)..];
    }

    public BgsPacket()
    {
    }

    public int HeaderLength { get; set; }
    public Header Header { get; set; }
    public byte[] MessageData { get; set; }

    public byte[] Serialize()
    {
        var rawHeader = new MemoryStream();
        Header.Token = requestToken++;
        Serializer.Serialize(rawHeader, Header);
        return BitConverter.GetBytes(Convert.ToUInt16(rawHeader.Length)).Reverse()
            .Concat(rawHeader.ToArray())
            .Concat(MessageData).ToArray();
    }
}