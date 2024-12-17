using Microsoft.AspNetCore.Components.Authorization;

namespace BabyData.Components.Account
{
    public class UserIdentityProcessor : IUserIdentityProcessor
    {
        private readonly AuthenticationStateProvider authenticationStateAsync;

        public UserIdentityProcessor(AuthenticationStateProvider authenticationStateAsync)
        {
            this.authenticationStateAsync = authenticationStateAsync;
        }

        public async Task<string?> GetCurrentUserId()
        {
            var authstate = await this.authenticationStateAsync.GetAuthenticationStateAsync();

            if (authstate == null)
            {
                return null;
            }

            var user = authstate.User;

            return user.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;
        }

        public async Task<string?> GetCurrentUserName()
        {
            var authstate = await this.authenticationStateAsync.GetAuthenticationStateAsync();

            if (authstate == null)
            {
                return null;
            }

            var identity = authstate.User.Identity;
            return identity?.Name;
        }
    }
}
