using BabyData.Data;
using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;

namespace BabyData.Components.Account
{
    internal sealed class UserIdentityProcessor : IUserIdentityProcessor
    {
        private readonly AuthenticationStateProvider authenticationStateAsync;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly NavigationManager navigation;
        private readonly IToastService toastService;

        public UserIdentityProcessor(AuthenticationStateProvider authenticationStateAsync, UserManager<ApplicationUser> userManager, NavigationManager navigation, IToastService toastService)
        {
            this.authenticationStateAsync = authenticationStateAsync;
            this.userManager = userManager;
            this.navigation = navigation;
            this.toastService = toastService;
        }

        private void InvalidUser()
        {
            toastService.ShowError($"Error: Unable to load user");
            navigation.NavigateTo("Account/InvalidUser");
        }

        public async Task<bool> IsCurrentUserAuthenticated()
        {
            var authstate = await authenticationStateAsync.GetAuthenticationStateAsync();
            var user = authstate?.User;
            return user?.Identity?.IsAuthenticated ?? false;
        }

        public async Task<Guid> GetCurrentUserId()
        {
            var authstate = await authenticationStateAsync.GetAuthenticationStateAsync();
            var user = authstate?.User;
            var useridString = user?.FindFirst(u => u.Type.Contains("nameidentifier"))?.Value;

            if (string.IsNullOrEmpty(useridString))
            {
                InvalidUser();
                return Guid.Empty;
            }

            return Guid.Parse(useridString);
        }

        public async Task<string> GetCurrentUserName()
        {
            var authstate = await authenticationStateAsync.GetAuthenticationStateAsync();
            var name = authstate?.User.Identity?.Name;
            if (name == null)
            {
                InvalidUser();
                return string.Empty;
            }

            return name;
        }

        public async Task<ApplicationUser> GetCurrentApplicationUser()
        {
            var authstate = await authenticationStateAsync.GetAuthenticationStateAsync();

            if (authstate == null)
                navigation.NavigateTo("Account/InvalidUser");

            var user = authstate?.User;
            if (user == null)
            {
                InvalidUser();
                return new ApplicationUser();
            }

            var userId = userManager.GetUserId(user);
            if (string.IsNullOrEmpty(userId))
            {
                InvalidUser();
                return new ApplicationUser();
            }
            
            var applicationUser = await userManager.FindByIdAsync(userId);
            if (applicationUser == null)
            {
                InvalidUser();
                return new ApplicationUser();
            }

            return applicationUser;
        }
    }
}
