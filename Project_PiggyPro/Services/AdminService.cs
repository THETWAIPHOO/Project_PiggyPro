using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Data;
using Microsoft.AspNetCore.Identity;

namespace Project_PiggyPro.Services
{
    public class AdminService
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;
        private readonly UserManager<Project_PiggyProUser> _userManager;

        public AdminService(
            IDbContextFactory<Project_PiggyProContext> contextFactory,
            UserManager<Project_PiggyProUser> userManager)
        {
            _contextFactory = contextFactory;
            _userManager = userManager;
        }

        // Get total number of users
        public async Task<int> GetTotalUsersAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Users.CountAsync();
        }

        // Get new users this week
        public async Task<int> GetNewUsersThisWeekAsync()
        {
            var oneWeekAgo = DateTime.UtcNow.AddDays(-7);
            using var context = await _contextFactory.CreateDbContextAsync();

            return await context.Users
                .Where(u => u.CreatedAt >= oneWeekAgo)
                .CountAsync();
        }

        // Get active users today (users who logged in today)
        public async Task<int> GetActiveUsersTodayAsync()
        {
            var today = DateTime.UtcNow.Date;
            using var context = await _contextFactory.CreateDbContextAsync();

            return await context.Users
                .Where(u => u.LastLoginDate >= today)
                .CountAsync();
        }

        // Get total transactions
        public async Task<int> GetTotalTransactionsAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Transaction.CountAsync();
        }

        // Get percentage of active users
        public async Task<decimal> GetActiveUsersPercentageAsync()
        {
            var totalUsers = await GetTotalUsersAsync();
            if (totalUsers == 0) return 0;

            var activeUsers = await GetActiveUsersTodayAsync();
            return Math.Round((decimal)activeUsers / totalUsers * 100, 0);
        }

        // Get recent user registrations
        public async Task<List<RecentUserDto>> GetRecentUsersAsync(int count = 5)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var users = await context.Users
                .OrderByDescending(u => u.CreatedAt)
                .Take(count)
                .Select(u => new RecentUserDto
                {
                    Id = u.Id,
                    Email = u.Email ?? "",
                    UserName = u.UserName ?? "",
                    CreatedAt = u.CreatedAt,
                    IsActive = u.LastLoginDate >= DateTime.UtcNow.AddDays(-7)
                })
                .ToListAsync();

            return users;
        }

        // Check system health (simple version)
        public async Task<SystemStatus> GetSystemStatusAsync()
        {
            try
            {
                using var context = await _contextFactory.CreateDbContextAsync();
                // Try to query database
                await context.Users.AnyAsync();

                return new SystemStatus
                {
                    IsHealthy = true,
                    Message = "HEALTHY"
                };
            }
            catch (Exception ex)
            {
                return new SystemStatus
                {
                    IsHealthy = false,
                    Message = "UNHEALTHY",
                    ErrorMessage = ex.Message
                };
            }
        }
    }

    // DTOs (Data Transfer Objects)
    public class RecentUserDto
    {
        public string Id { get; set; } = "";
        public string Email { get; set; } = "";
        public string UserName { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }

    public class SystemStatus
    {
        public bool IsHealthy { get; set; }
        public string Message { get; set; } = "";
        public string? ErrorMessage { get; set; }
    }
}