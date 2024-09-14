using bgs.protocol.authentication.v1;

namespace EvilBlizzard.Services;

[Service(0xdecfc01)]
public class AuthenticationService : IService
{
    [ServiceMethod(1)]
    public void Logon(LogonRequest request)
    {
        Console.WriteLine($"AuthenticationService::Logon - email={request.Email} version={request.Version} program={request.Program}");
    }
}