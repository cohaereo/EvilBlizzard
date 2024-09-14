using bgs.protocol.friends.v1;

namespace EvilBlizzard.Services;

[Service(0xA3DDB1BD)]
public class FriendsService : Service
{
    [ServiceMethod(1)]
    public SubscribeResponse Subscribe(SubscribeRequest request)
    {
        return new SubscribeResponse();
    }
}