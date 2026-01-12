using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_PiggyPro.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Project_PiggyProUser : IdentityUser
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastLoginDate { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        [NotMapped]
        public string FullName => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
        ? $"{FirstName} {LastName}"
        : UserName ?? "Unknown User";
    }
}
