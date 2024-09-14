using System.Text.Json;
using bgs.protocol;
using bgs.protocol.presence.v1;

namespace EvilBlizzard.Services;

[Service(0xFA0796FF)]
public class PresenceService : Service
{
    [ServiceMethod(1)]
    public NoData Subscribe(SubscribeRequest request)
    {
        return new NoData();
    }

    [ServiceMethod(3)]
    public NoData Update(UpdateRequest request)
    {
        Console.WriteLine($"PresenceService::Update - {JsonSerializer.Serialize(request)}");
        return new NoData();
    }
}