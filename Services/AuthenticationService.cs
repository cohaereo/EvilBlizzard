using System.Text.Json;
using bgs.protocol;
using bgs.protocol.authentication.v1;

namespace EvilBlizzard.Services;

[Service(0x71240E35)]
public class AuthenticationListener : Service
{
    public static uint ServiceHash => GetServiceHash(typeof(AuthenticationListener));
}

[Service(0xDECFC01)]
public class AuthenticationService : Service
{
    public static byte[] SessionKey = new byte[64];

    [ServiceMethod(1)]
    public NoData Logon(LogonRequest request, RequestContext ctx)
    {
        Console.WriteLine($"AuthenticationService::Logon - request={JsonSerializer.Serialize(request)}");

        Random.Shared.NextBytes(SessionKey);
        var logonResult = new LogonResult
        {
            ErrorCode = 0,
            AccountId = new EntityId
            {
                High = 0x100000000000000,
                Low = 0xfeedface
            },
            GameAccountIds = { new EntityId { High = 0x200000200576F57, Low = 0xdeadbeef12341234 } },
            SessionKey = SessionKey,
            BattleTag = "cohaereo#0666",
            Email = "cohae@cohae.dev",
            // ClientId = "someclient",
            RestrictedMode = false
        };

        // OnLogonComplete
        ctx.SendNotification(AuthenticationListener.ServiceHash, 5, logonResult);

        return new NoData();
    }

    [ServiceMethod(8)]
    public GenerateWebCredentialsResponse GenerateWebCredentials(GenerateWebCredentialsRequest request, RequestContext ctx)
    {
        return new GenerateWebCredentialsResponse
        {
            WebCredentials = "CN-97e2280792852a25e356fc9897f8bcd5-525139407"u8.ToArray()
        };
    }
}