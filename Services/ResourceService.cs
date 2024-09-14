using bgs.protocol;
using bgs.protocol.resources.v1;

namespace EvilBlizzard.Services;

[Service(0xECBE75BA)]
public class ResourceService : Service
{
    [ServiceMethod(1)]
    public ContentHandle GetContentHandle(ContentHandleRequest request, RequestContext ctx)
    {
        ctx.Error = ErrorCode.NotExists;
        return new ContentHandle
        {
            Region = 0x5553,
            Usage = 0,
            Hash = new byte[] { }
        };
    }
}