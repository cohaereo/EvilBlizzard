using bgs.protocol.account.v1;

namespace EvilBlizzard.Services;

[Service(0x62DA0891)]
public class AccountService : Service
{
    [ServiceMethod(30)]
    public GetAccountStateResponse GetAccountState(GetAccountStateRequest request)
    {
        var state = new GetAccountStateResponse();

        if (request.Options.FieldPrivacyInfo)
            state.State.PrivacyInfo = new PrivacyInfo
            {
                IsUsingRid = true,
                IsHiddenFromFriendFinder = false,
                IsVisibleForViewFriends = true,
                game_info_privacy = PrivacyInfo.GameInfoPrivacy.PrivacyEveryone
            };

        if (request.Options.FieldAccountLevelInfo)
        {
            var level = new AccountLevelInfo
            {
                Country = "US",
                Email = "cohae@cohae.dev",
                BattleTag = "cohaereo#0666",
                FullName = "Firstname Lastname",
                PreferredRegion = 1,
                AccountPaidAny = true
            };

            for (uint i = 0; i < 16; i++)
                level.Licenses.Add(new AccountLicense
                {
                    Id = i
                });

            state.State.AccountLevelInfo = level;
            state.Tags.AccountLevelInfoTag = 3827081107;
        }

        return state;
    }
}