using BabyData.Data;

namespace BabyData.Components.Account
{
    public interface IUserIdentityProcessor
    {
        Task<bool> IsCurrentUserAuthenticated();
        Task<Guid> GetCurrentUserId();
        Task<string> GetCurrentUserName();
        Task<ApplicationUser> GetCurrentApplicationUser();


    }
}
