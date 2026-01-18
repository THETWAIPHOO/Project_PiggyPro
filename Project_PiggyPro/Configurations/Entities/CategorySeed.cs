using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_PiggyPro.Domain;
using System.Drawing;

namespace Project_PiggyPro.Configurations.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, CategoryName = "Housing & Rent", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 2, CategoryName = "Groceries", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 3, CategoryName = "Utilities", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 4, CategoryName = "Transportation", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 5, CategoryName = "Healthcare", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

        // Expense Categories (Wants - 30%)
                new Category { Id = 6, CategoryName = "Dining Out", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 7, CategoryName = "Entertainment", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 8, CategoryName = "Shopping", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 9, CategoryName = "Hobbies", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

        // Expense Categories (Savings - 20%)
                new Category { Id = 10, CategoryName = "Savings", CategoryType = "Savings", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 11, CategoryName = "Investments", CategoryType = "Savings", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 12, CategoryName = "Emergency Fund", CategoryType = "Savings", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 13, CategoryName = "Savings Goal", CategoryType = "Savings", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

                // Other
                new Category { Id = 14, CategoryName = "Other Expenses", CategoryType = "Expense", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },

        // Income Categories
                new Category { Id = 15, CategoryName = "Salary", CategoryType = "Income", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 16, CategoryName = "Freelance", CategoryType = "Income", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 17, CategoryName = "Investment Income", CategoryType = "Income", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 18, CategoryName = "Gift/Bonus", CategoryType = "Income", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" },
                new Category { Id = 19, CategoryName = "Other Income", CategoryType = "Income", IsSystemCategory = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now, CreatedBy = "System", UpdatedBy = "System" }
                );

        }
    }
}
