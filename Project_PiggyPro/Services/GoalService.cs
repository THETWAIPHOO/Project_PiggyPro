using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Data;
using Project_PiggyPro.Domain;

namespace Project_PiggyPro.Services
{
    public class GoalService
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;

        public GoalService(IDbContextFactory<Project_PiggyProContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        // Get all goals for a user
        public async Task<List<Goal>> GetUserGoalsAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Goal
                .Where(g => g.AppUserId == userId)
                .OrderByDescending(g => g.DateCreated)
                .ToListAsync();
        }

        // Get goal by ID
        public async Task<Goal?> GetGoalByIdAsync(int goalId, string userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Goal
                .FirstOrDefaultAsync(g => g.Id == goalId && g.AppUserId == userId);
        }

        // Create goal
        public async Task<bool> CreateGoalAsync(Goal goal)
        {
            using var context = _contextFactory.CreateDbContext();
            goal.DateCreated = DateTime.Now;
            goal.DateUpdated = DateTime.Now;
            goal.Status = "Active";
            goal.CurrentAmount = 0;

            context.Goal.Add(goal);
            return await context.SaveChangesAsync() > 0;
        }

        // Update goal
        public async Task<bool> UpdateGoalAsync(Goal goal)
        {
            using var context = _contextFactory.CreateDbContext();

            var existingGoal = await context.Goal.FindAsync(goal.Id);
            if (existingGoal == null) return false;

            existingGoal.GoalName = goal.GoalName;
            existingGoal.Description = goal.Description;
            existingGoal.TargetAmount = goal.TargetAmount;
            existingGoal.TargetDate = goal.TargetDate;
            existingGoal.Category = goal.Category;
            existingGoal.DateUpdated = DateTime.Now;
            existingGoal.UpdatedBy = goal.UpdatedBy;

            return await context.SaveChangesAsync() > 0;
        }

        // Add funds to goal - WITH TRANSACTION TRACKING
        public async Task<bool> AddFundsToGoalAsync(int goalId, decimal amount, string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var goal = await context.Goal
                .FirstOrDefaultAsync(g => g.Id == goalId && g.AppUserId == userId);

            if (goal == null) return false;

            // Find or create "Savings Goal" category
            var savingsGoalCategory = await context.Category
                .FirstOrDefaultAsync(c => c.CategoryName == "Savings Goal" && c.CategoryType == "Savings");

            if (savingsGoalCategory == null)
            {
                savingsGoalCategory = new Category
                {
                    CategoryName = "Savings Goal",
                    CategoryType = "Savings",
                    AppUserId = userId,
                    DateCreated = DateTime.Now,
                    CreatedBy = userId,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = userId
                };
                context.Category.Add(savingsGoalCategory);
                await context.SaveChangesAsync();
            }

            // Create a transaction record (moving money INTO the goal = Expense from savings)
            var transaction = new Transaction
            {
                Amount = amount,
                TransactionType = "Expense",
                TransactionDate = DateTime.Now,
                Description = $"Added ${amount:F2} to goal: {goal.GoalName}",
                CategoryId = savingsGoalCategory.Id,
                AppUserId = userId,
                DateCreated = DateTime.Now,
                CreatedBy = userId,
                DateUpdated = DateTime.Now,
                UpdatedBy = userId
            };

            context.Transaction.Add(transaction);

            // Update goal amount
            goal.CurrentAmount += amount;
            goal.DateUpdated = DateTime.Now;

            // Auto-complete if target reached
            if (goal.CurrentAmount >= goal.TargetAmount)
            {
                goal.Status = "Completed";
            }

            return await context.SaveChangesAsync() > 0;
        }

        // Withdraw funds from goal - WITH TRANSACTION TRACKING
        public async Task<bool> WithdrawFundsFromGoalAsync(int goalId, decimal amount, string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var goal = await context.Goal
                .FirstOrDefaultAsync(g => g.Id == goalId && g.AppUserId == userId);

            if (goal == null || goal.CurrentAmount < amount) return false;

            // Find "Savings Goal" category
            var savingsGoalCategory = await context.Category
                .FirstOrDefaultAsync(c => c.CategoryName == "Savings Goal" && c.CategoryType == "Savings");

            if (savingsGoalCategory != null)
            {
                // Create a transaction record (taking money OUT of goal = Income back to savings)
                var transaction = new Transaction
                {
                    Amount = amount,
                    TransactionType = "Income",
                    TransactionDate = DateTime.Now,
                    Description = $"Withdrew ${amount:F2} from goal: {goal.GoalName}",
                    CategoryId = savingsGoalCategory.Id,
                    AppUserId = userId,
                    DateCreated = DateTime.Now,
                    CreatedBy = userId,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = userId
                };

                context.Transaction.Add(transaction);
            }

            // Update goal amount
            goal.CurrentAmount -= amount;
            goal.DateUpdated = DateTime.Now;

            // Change status back to Active if it was completed
            if (goal.Status == "Completed")
            {
                goal.Status = "Active";
            }

            return await context.SaveChangesAsync() > 0;
        }

        // Delete goal
        public async Task<bool> DeleteGoalAsync(int goalId, string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var goal = await context.Goal
                .FirstOrDefaultAsync(g => g.Id == goalId && g.AppUserId == userId);

            if (goal == null) return false;

            context.Goal.Remove(goal);
            return await context.SaveChangesAsync() > 0;
        }

        // Mark goal as completed
        public async Task<bool> CompleteGoalAsync(int goalId, string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var goal = await context.Goal
                .FirstOrDefaultAsync(g => g.Id == goalId && g.AppUserId == userId);

            if (goal == null) return false;

            goal.Status = "Completed";
            goal.DateUpdated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }

        // Get goal statistics
        public async Task<GoalStatsDto> GetGoalStatsAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var goals = await context.Goal
                .Where(g => g.AppUserId == userId)
                .ToListAsync();

            return new GoalStatsDto
            {
                TotalGoals = goals.Count,
                ActiveGoals = goals.Count(g => g.Status == "Active"),
                CompletedGoals = goals.Count(g => g.Status == "Completed"),
                TotalTargetAmount = goals.Where(g => g.Status == "Active").Sum(g => g.TargetAmount),
                TotalSavedAmount = goals.Where(g => g.Status == "Active").Sum(g => g.CurrentAmount),
                OverallProgress = goals.Where(g => g.Status == "Active").Any()
                    ? goals.Where(g => g.Status == "Active").Average(g => g.ProgressPercentage)
                    : 0
            };
        }

        // NEW: Get available savings budget for goals
        public async Task<decimal> GetAvailableSavingsBudgetAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            // Get current month's savings budgets
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            var savingsBudgets = await context.Budget
                .Where(b => b.AppUserId == userId &&
                           b.BucketType == "Savings" &&
                           b.StartDate <= now &&
                           b.EndDate >= now)
                .Include(b => b.Category)
                .ToListAsync();

            decimal totalSavingsBudget = savingsBudgets.Sum(b => b.AllocatedAmount);

            // Get all savings expenses (including goal allocations)
            var savingsCategories = savingsBudgets.Select(b => b.CategoryId).ToList();

            decimal totalSpent = await context.Transaction
                .Where(t => t.AppUserId == userId &&
                           savingsCategories.Contains(t.CategoryId) &&
                           t.TransactionType == "Expense" &&
                           t.TransactionDate >= startOfMonth &&
                           t.TransactionDate <= endOfMonth)
                .SumAsync(t => t.Amount);

            return totalSavingsBudget - totalSpent;
        }

        // NEW: Get total money in all goals
        public async Task<decimal> GetTotalInGoalsAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Goal
                .Where(g => g.AppUserId == userId && g.Status == "Active")
                .SumAsync(g => g.CurrentAmount);
        }
    }

    // DTO for statistics
    public class GoalStatsDto
    {
        public int TotalGoals { get; set; }
        public int ActiveGoals { get; set; }
        public int CompletedGoals { get; set; }
        public decimal TotalTargetAmount { get; set; }
        public decimal TotalSavedAmount { get; set; }
        public decimal OverallProgress { get; set; }
    }
}