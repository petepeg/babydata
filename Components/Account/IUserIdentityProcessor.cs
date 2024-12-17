namespace BabyData.Components.Account
{
    public interface IUserIdentityProcessor
    {
        Task<string?> GetCurrentUserId();
        Task<string?> GetCurrentUserName();

    }
}
