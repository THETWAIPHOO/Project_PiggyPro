using System.ComponentModel.DataAnnotations;

namespace Project_PiggyPro.Domain
{
    public class AppUser : BaseDomainModel
    {
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public bool IsEmailVerified { get; set; }
    }
}
