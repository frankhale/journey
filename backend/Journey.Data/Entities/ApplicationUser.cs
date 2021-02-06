using Microsoft.AspNetCore.Identity;

namespace Journey.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string DisplayName { get; set; }
    }
}
