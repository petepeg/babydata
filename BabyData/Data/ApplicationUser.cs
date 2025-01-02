using Microsoft.AspNetCore.Identity;

namespace BabyData.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //placeholder till i create an actual stored value
        public TimeZoneInfo TimeZoneInfo => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
    }

}
