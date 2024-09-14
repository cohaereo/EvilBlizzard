using bgs.protocol.account.v1;

namespace EvilBlizzard.Services;

[Service(0x62DA0891)]
public class AccountService : Service
{
    [ServiceMethod(30)]
    public GetAccountStateResponse GetAccountState(GetAccountStateRequest request)
    {
        return new GetAccountStateResponse();
    }
}