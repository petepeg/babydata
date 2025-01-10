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

        public async Task<Guid?> GetCurrentUserId()
        {
            var authstate = await this.authenticationStateAsync.GetAuthenticationStateAsync();

            if (authstate == null)
                return null;

            var user = authstate.User;
            var useridString = user.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;
            
            if (string.IsNullOrEmpty(useridString))
                return null;

            return Guid.Parse(useridString);
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
