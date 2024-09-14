using bgs.protocol;
using bgs.protocol.connection.v1;
using EvilBlizzard.Extensions;

namespace EvilBlizzard.Services;

[Service(0x65446991)]
public class ConnectionService : Service
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
                Epoch = DateTime.Now.ToUnixTime(),
                Label = (uint)Environment.ProcessId
            },
            ClientId = request.ClientId,
            UseBindlessRpc = request.UseBindlessRpc
        };
    }

    [ServiceMethod(5)]
    public void KeepAlive(NoData _)
    {
        // 👍
    }

    [ServiceMethod(7)]
    public void RequestDisconnect(DisconnectRequest request)
    {
        Console.WriteLine($"ConnectionService::RequestDisconnect - error_code={request.ErrorCode}");
    }
}