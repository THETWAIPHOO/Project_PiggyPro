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
        // Get all users with pagination
        public async Task<UserManagementDto> GetUsersAsync(int page = 1, int pageSize = 10, string searchTerm = "")
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var query = context.Users.AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(u =>
                    u.Email!.Contains(searchTerm) ||
                    u.UserName!.Contains(searchTerm));
            }

            var totalUsers = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalUsers / (double)pageSize);

            var users = await query
                .OrderByDescending(u => u.CreatedAt)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    UserName = u.UserName ?? "",
                    Email = u.Email ?? "",
                    EmailConfirmed = u.EmailConfirmed,
                    CreatedAt = u.CreatedAt,
                    LastLoginDate = u.LastLoginDate,
                    IsActive = u.LastLoginDate >= DateTime.UtcNow.AddDays(-30)
                })
                .ToListAsync();

            // Get roles for each user
            foreach (var user in users)
            {
                var appUser = await _userManager.FindByIdAsync(user.Id);
                if (appUser != null)
                {
                    var roles = await _userManager.GetRolesAsync(appUser);
                    user.Roles = roles.ToList();
                }
            }

            return new UserManagementDto
            {
                Users = users,
                CurrentPage = page,
                TotalPages = totalPages,
                TotalUsers = totalUsers,
                PageSize = pageSize
            };
        }

        // Get user by ID
        public async Task<UserDetailDto?> GetUserByIdAsync(string userId)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var user = await context.Users.FindAsync(userId);
            if (user == null) return null;

            var appUser = await _userManager.FindByIdAsync(userId);
            var roles = appUser != null ? await _userManager.GetRolesAsync(appUser) : new List<string>();

            return new UserDetailDto
            {
                Id = user.Id,
                UserName = user.UserName ?? "",
                Email = user.Email ?? "",
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumber = user.PhoneNumber,
                CreatedAt = user.CreatedAt,
                LastLoginDate = user.LastLoginDate,
                Roles = roles.ToList()
            };
        }

        // Get user statistics
        public async Task<UserStatsDto> GetUserStatsAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var totalUsers = await context.Users.CountAsync();
            var activeUsers = await context.Users
                .CountAsync(u => u.LastLoginDate >= DateTime.UtcNow.AddDays(-30));
            var newUsersThisMonth = await context.Users
                .CountAsync(u => u.CreatedAt >= DateTime.UtcNow.AddDays(-30));
            var verifiedUsers = await context.Users
                .CountAsync(u => u.EmailConfirmed);

            return new UserStatsDto
            {
                TotalUsers = totalUsers,
                ActiveUsers = activeUsers,
                NewUsersThisMonth = newUsersThisMonth,
                VerifiedUsers = verifiedUsers
            };
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
        // Get user registration data for the last 7 days
        public async Task<UserGrowthData> GetUserGrowthDataAsync(int days = 7)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var startDate = DateTime.UtcNow.AddDays(-days).Date;
            var labels = new List<string>();
            var data = new List<int>();

            for (int i = days - 1; i >= 0; i--)
            {
                var date = DateTime.UtcNow.AddDays(-i).Date;
                var count = await context.Users
                    .CountAsync(u => u.CreatedAt.Date == date);

                labels.Add(date.ToString("MMM dd"));
                data.Add(count);
            }

            return new UserGrowthData
            {
                Labels = labels,
                Data = data
            };
        }

        // Get user activity data (active vs inactive)
        public async Task<UserActivityData> GetUserActivityDataAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var activeCount = await context.Users
                .CountAsync(u => u.LastLoginDate >= DateTime.UtcNow.AddDays(-30));

            var inactiveCount = await context.Users
                .CountAsync(u => u.LastLoginDate == null || u.LastLoginDate < DateTime.UtcNow.AddDays(-30));

            return new UserActivityData
            {
                ActiveUsers = activeCount,
                InactiveUsers = inactiveCount
            };
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
    public class UserManagementDto
    {
        public List<UserDto> Users { get; set; } = new();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalUsers { get; set; }
        public int PageSize { get; set; }
    }

    public class UserDto
    {
        public string Id { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Email { get; set; } = "";
        public bool EmailConfirmed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool IsActive { get; set; }
        public List<string> Roles { get; set; } = new();
    }

    public class UserDetailDto
    {
        public string Id { get; set; } = "";
        public string UserName { get; set; } = "";
        public string Email { get; set; } = "";
        public bool EmailConfirmed { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public List<string> Roles { get; set; } = new();
    }

    public class UserStatsDto
    {
        public int TotalUsers { get; set; }
        public int ActiveUsers { get; set; }
        public int NewUsersThisMonth { get; set; }
        public int VerifiedUsers { get; set; }
    }
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
    public class UserGrowthData
    {
        public List<string> Labels { get; set; } = new();
        public List<int> Data { get; set; } = new();
    }

    public class UserActivityData
    {
        public int ActiveUsers { get; set; }
        public int InactiveUsers { get; set; }
    }
}