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

        // Add funds to goal
        public async Task<bool> AddFundsToGoalAsync(int goalId, decimal amount, string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var goal = await context.Goal
                .FirstOrDefaultAsync(g => g.Id == goalId && g.AppUserId == userId);

            if (goal == null) return false;

            goal.CurrentAmount += amount;
            goal.DateUpdated = DateTime.Now;

            // Auto-complete if target reached
            if (goal.CurrentAmount >= goal.TargetAmount)
            {
                goal.Status = "Completed";
            }

            return await context.SaveChangesAsync() > 0;
        }

        // Withdraw funds from goal
        public async Task<bool> WithdrawFundsFromGoalAsync(int goalId, decimal amount, string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var goal = await context.Goal
                .FirstOrDefaultAsync(g => g.Id == goalId && g.AppUserId == userId);

            if (goal == null || goal.CurrentAmount < amount) return false;

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