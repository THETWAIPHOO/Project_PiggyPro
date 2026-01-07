using Project_PiggyPro.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Data;

namespace Project_PiggyPro.Data
{
    public class Project_PiggyProContext(DbContextOptions<Project_PiggyProContext> options) : IdentityDbContext<Project_PiggyProUser>(options)
    {
        
        public DbSet<Project_PiggyPro.Domain.Budget> Budget { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Category> Category { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Goal> Goal { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Notification> Notification { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Transaction> Transaction { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategorySeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
