using Project_PiggyPro.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Project_PiggyPro.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<Project_PiggyProUser>
    {
        public void Configure(EntityTypeBuilder<Project_PiggyProUser> builder)
        {
            var hasher = new PasswordHasher<Project_PiggyProUser>();
            builder.HasData(
            new Project_PiggyProUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}