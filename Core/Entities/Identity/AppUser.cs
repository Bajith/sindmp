using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}