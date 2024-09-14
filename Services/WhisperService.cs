using bgs.protocol.whisper.v1;

namespace EvilBlizzard.Services;

[Service(0xC12828F9)]
public class WhisperService : Service
{
    [ServiceMethod(1)]
    public SubscribeResponse Subscribe(SubscribeRequest request)
    {
        return new SubscribeResponse();
    }
}