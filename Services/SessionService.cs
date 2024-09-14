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

        var start = "A7B5C8B0593FFEC10000000";
        var end = "BCABD";
        var session = start + Random.Shared.Next(0, 9) + Random.Shared.Next(0, 9) + Random.Shared.Next(0, 9) + Random.Shared.Next(0, 9) + end;

        var onSessionCreated = new SessionCreatedNotification
        {
            SessionId = session,
            Identity = request.Identity,
            Reason = 0
        };
        // OnSessionCreated
        ctx.SendNotification(SessionListener.ServiceHash, 1, onSessionCreated);

        return new CreateSessionResponse
        {
            SessionId = session
            // TimeoutS = uint.MaxValue
        };
    }

    [ServiceMethod(10)]
    public GetSignedSessionStateResponse GetSignedSessionState(GetSignedSessionStateRequest request, RequestContext ctx)
    {
        return new GetSignedSessionStateResponse
        {
            Token = "eyJ0eXAiOiJKV1QiLCJlbnYiOiJwcm9kLmV1IiwiYWxnIjoiUlMyNTYiLCJraWQiOiJmMDE5NzgzMi0zMWMwLTQzN2MtOTc2NC1iMzliOTM5MDJlNWMiLCJrdHkiOiJSU0EifQ"
        };
    }
}