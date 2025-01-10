namespace BabyData.Components.Account
{
    public interface IUserIdentityProcessor
    {
        Task<Guid?> GetCurrentUserId();
        Task<string?> GetCurrentUserName();

    }
}
