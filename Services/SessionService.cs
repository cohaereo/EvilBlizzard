using System.Text.Json;
using bgs.protocol.session.v1;

namespace EvilBlizzard.Services;

[Service(0x7FE36B32)]
public class SessionListener : Service
{
    public static uint ServiceHash => GetServiceHash(typeof(SessionListener));
}

[Service(0x1E688C05)]
public class SessionService : Service
{
    [ServiceMethod(1)]
    public CreateSessionResponse CreateSession(CreateSessionRequest request, RequestContext ctx)
    {
        Console.WriteLine($"SessionService::CreateSession - {JsonSerializer.Serialize(request)}");

        var onSessionCreated = new SessionCreatedNotification
        {
            SessionId = "destiny_n_chill"
            // ClientId = "someclient",
            // SessionKey = AuthenticationService.SessionKey
        };
        // OnSessionCreated
        ctx.SendNotification(SessionListener.ServiceHash, 1, onSessionCreated);

        return new CreateSessionResponse
        {
            SessionId = "destiny_n_chill"
            // TimeoutS = uint.MaxValue
        };
    }
}