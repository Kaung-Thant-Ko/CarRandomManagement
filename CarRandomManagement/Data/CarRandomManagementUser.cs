using Microsoft.AspNetCore.Identity;

namespace CarRandomManagement.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarRandomManagementUser : IdentityUser
    {
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
    }
}
