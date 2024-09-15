using bgs.protocol;
using bgs.protocol.channel.v2.membership;

namespace EvilBlizzard.Services;

[Service(0x7E525E99)]
public class ChannelMembershipService : Service
{
    [ServiceMethod(1)]
    public NoData Subscribe(SubscribeRequest request)
    {
        return new NoData();
    }
}