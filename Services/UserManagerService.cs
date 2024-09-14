using bgs.protocol.usermanager.v1;

namespace EvilBlizzard.Services;

[Service(0x3E19268A)]
public class UserManagerService : Service
{
    [ServiceMethod(1)]
    public SubscribeResponse Subscribe(SubscribeRequest request)
    {
        return new SubscribeResponse();
    }
}