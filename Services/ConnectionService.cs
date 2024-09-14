using bgs.protocol;
using bgs.protocol.connection.v1;

namespace EvilBlizzard.Services;

[Service(0x65446991)]
public class ConnectionService : IService
{
    [ServiceMethod(1)]
    public ConnectResponse Connect(ConnectRequest request)
    {
        Console.WriteLine($"ConnectionService::Connect - client_id={request.ClientId}, bindless={request.UseBindlessRpc}");

        var unixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        return new ConnectResponse
        {
            ServerId = new ProcessId
            {
                Epoch = (uint)unixTime,
                Label = (uint)Environment.ProcessId
            },
            ServerTime = (uint)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        };
    }
}