using Microsoft.AspNetCore.Identity;

namespace Journey.Identity.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string DisplayName { get; set; }
    }
}
