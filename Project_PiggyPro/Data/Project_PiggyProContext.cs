using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Configurations.Entities;
using Project_PiggyPro.Domain;

namespace Project_PiggyPro.Data
{
    public class Project_PiggyProContext : DbContext
    {
        public Project_PiggyProContext (DbContextOptions<Project_PiggyProContext> options)
            : base(options)
        {
        }

        public DbSet<Project_PiggyPro.Domain.AppUser> AppUser { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Budget> Budget { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Category> Category { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Goal> Goal { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Notification> Notification { get; set; } = default!;
        public DbSet<Project_PiggyPro.Domain.Transaction> Transaction { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategorySeed());
        }
    }
}
