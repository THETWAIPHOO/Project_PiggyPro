using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Data;

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

        // ============= USER MANAGEMENT =============

        // Get paginated users with search
        public async Task<UserManagementDto> GetUsersAsync(int page = 1, int pageSize = 10, string searchTerm = "")
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var query = context.Users.AsQueryable();

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(u =>
                    u.Email!.Contains(searchTerm) ||
                    u.UserName!.Contains(searchTerm) ||
                    u.FirstName!.Contains(searchTerm) ||
                    u.LastName!.Contains(searchTerm));
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
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email ?? "",
                    EmailConfirmed = u.EmailConfirmed,
                    CreatedAt = u.CreatedAt,
                    LastLoginDate = u.LastLoginDate,
                    // Check if user is locked out
                    IsActive = u.LockoutEnd == null || u.LockoutEnd <= DateTimeOffset.UtcNow
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
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email ?? "",
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumber = user.PhoneNumber,
                CreatedAt = user.CreatedAt,
                LastLoginDate = user.LastLoginDate,
                Roles = roles.ToList()
            };
        }

        // Toggle user active status - BLOCKS USER FROM LOGIN
        public async Task<bool> ToggleUserActiveStatusAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;

            // Check if user is admin - don't allow deactivation
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Any(r => r.Equals("Administrator", StringComparison.OrdinalIgnoreCase)))
            {
                return false; // Cannot deactivate admin
            }

            // Toggle lockout status
            if (user.LockoutEnd == null || user.LockoutEnd <= DateTimeOffset.UtcNow)
            {
                // Currently active - LOCK the account
                user.LockoutEnabled = true;
                user.LockoutEnd = DateTimeOffset.MaxValue; // Lock indefinitely
                user.LastLoginDate = DateTime.UtcNow.AddDays(-31); // Mark as inactive
            }
            else
            {
                // Currently locked - UNLOCK the account
                user.LockoutEnabled = false;
                user.LockoutEnd = null;
                user.LastLoginDate = DateTime.UtcNow; // Mark as active
            }

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }

        // Update user information
        public async Task<bool> UpdateUserAsync(
            string userId,
            string firstName,
            string lastName,
            string email,
            string? phoneNumber,
            bool emailConfirmed)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;

            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.NormalizedEmail = email.ToUpper();
            user.PhoneNumber = phoneNumber;
            user.EmailConfirmed = emailConfirmed;

            var result = await _userManager.UpdateAsync(user);
            return result.Succeeded;
        }

        // Delete user (optional)
        public async Task<bool> DeleteUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return false;

            // Check if user is admin - don't allow deletion
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Any(r => r.Equals("Administrator", StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            var result = await _userManager.DeleteAsync(user);
            return result.Succeeded;
        }

        // ============= DASHBOARD STATISTICS =============

        // Get total users count
        public async Task<int> GetTotalUsersAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Users.CountAsync();
        }

        // Get new users this week
        public async Task<int> GetNewUsersThisWeekAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var weekAgo = DateTime.UtcNow.AddDays(-7);
            return await context.Users.CountAsync(u => u.CreatedAt >= weekAgo);
        }

        // Get active users today (logged in within 24 hours)
        public async Task<int> GetActiveUsersTodayAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var yesterday = DateTime.UtcNow.AddDays(-1);
            return await context.Users.CountAsync(u => u.LastLoginDate >= yesterday);
        }

        // Get total transactions count
        public async Task<int> GetTotalTransactionsAsync()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            return await context.Transaction.CountAsync();
        }

        // Get system status
        public async Task<SystemStatus> GetSystemStatusAsync()
        {
            try
            {
                using var context = await _contextFactory.CreateDbContextAsync();
                // Try to query database
                await context.Users.CountAsync();

                return new SystemStatus
                {
                    IsHealthy = true,
                    Message = "All systems operational"
                };
            }
            catch
            {
                return new SystemStatus
                {
                    IsHealthy = false,
                    Message = "Database connection issue"
                };
            }
        }

        // Get recent users
        public async Task<List<RecentUserDto>> GetRecentUsersAsync(int count = 10)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            return await context.Users
                .OrderByDescending(u => u.CreatedAt)
                .Take(count)
                .Select(u => new RecentUserDto
                {
                    Id = u.Id,
                    Email = u.Email ?? "",
                    UserName = u.UserName ?? "",
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    CreatedAt = u.CreatedAt,
                    IsActive = u.LockoutEnd == null || u.LockoutEnd <= DateTimeOffset.UtcNow
                })
                .ToListAsync();
        }
        // ============= CHART DATA FOR ADMIN DASHBOARD =============

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

            // Active = not locked out
            var activeCount = await context.Users
                .CountAsync(u => u.LockoutEnd == null || u.LockoutEnd <= DateTimeOffset.UtcNow);

            // Inactive = locked out
            var inactiveCount = await context.Users
                .CountAsync(u => u.LockoutEnd != null && u.LockoutEnd > DateTimeOffset.UtcNow);

            return new UserActivityData
            {
                ActiveUsers = activeCount,
                InactiveUsers = inactiveCount
            };
        }
    }

    // ============= DTOs =============

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
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = "";
        public bool EmailConfirmed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool IsActive { get; set; }
        public List<string> Roles { get; set; } = new();

        // Computed property for display
        public string DisplayName => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
            ? $"{FirstName} {LastName}"
            : UserName;
    }

    public class UserDetailDto
    {
        public string Id { get; set; } = "";
        public string UserName { get; set; } = "";
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = "";
        public bool EmailConfirmed { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public List<string> Roles { get; set; } = new();

        // Computed property for display
        public string FullName => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
            ? $"{FirstName} {LastName}"
            : UserName;
    }

    public class RecentUserDto
    {
        public string Id { get; set; } = "";
        public string Email { get; set; } = "";
        public string UserName { get; set; } = "";
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        // Computed property for display
        public string DisplayName => !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
            ? $"{FirstName} {LastName}"
            : UserName;
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
    public class SystemStatus
    {
        public bool IsHealthy { get; set; }
        public string Message { get; set; } = "";
    }
}