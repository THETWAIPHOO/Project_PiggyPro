using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Data;
using Project_PiggyPro.Domain;

namespace Project_PiggyPro.Services
{
    public interface IInAppNotificationService
    {
        Task CreateNotificationAsync(string userId, string title, string message, string type, string? icon = null, string? actionUrl = null, string priority = "Normal");
        Task<List<Notification>> GetRecentNotificationsAsync(string userId, int count = 5);
        Task<List<Notification>> GetAllNotificationsAsync(string userId);
        Task<int> GetUnreadCountAsync(string userId);
        Task MarkAsReadAsync(int notificationId);
        Task MarkAllAsReadAsync(string userId);
        Task DeleteNotificationAsync(int notificationId);

        // Specific notification creators
        Task NotifyBudgetAlertAsync(string userId, string categoryName, decimal spent, decimal limit, decimal percentage);
        Task NotifyGoalProgressAsync(string userId, string goalName, decimal current, decimal target, decimal percentage);
        Task NotifyTransactionAddedAsync(string userId, string description, decimal amount, string type);
        Task NotifyGoalAchievedAsync(string userId, string goalName, decimal amount);
        Task NotifyBudgetExceededAsync(string userId, string categoryName, decimal spent, decimal limit);
    }

    public class InAppNotificationService : IInAppNotificationService
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;
        private readonly ILogger<InAppNotificationService> _logger;

        public InAppNotificationService(
            IDbContextFactory<Project_PiggyProContext> contextFactory,
            ILogger<InAppNotificationService> logger)
        {
            _contextFactory = contextFactory;
            _logger = logger;
        }

        public async Task CreateNotificationAsync(
            string userId,
            string title,
            string message,
            string type,
            string? icon = null,
            string? actionUrl = null,
            string priority = "Normal")
        {
            try
            {
                using var context = await _contextFactory.CreateDbContextAsync();

                var notification = new Notification
                {
                    AppUserId = userId,
                    Title = title,
                    Message = message,
                    NotificationType = type,
                    Icon = icon ?? GetDefaultIcon(type),
                    ActionUrl = actionUrl,
                    Priority = priority,
                    IsRead = false,
                    CreatedBy = userId,
                    UpdatedBy = userId,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now
                };

                context.Notification.Add(notification);
                await context.SaveChangesAsync();

                _logger.LogInformation($"Notification created for user {userId}: {title}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error creating notification for user {userId}");
            }
        }

        public async Task<List<Notification>> GetRecentNotificationsAsync(string userId, int count = 5)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            return await context.Notification
                .Where(n => n.AppUserId == userId)
                .OrderByDescending(n => n.DateCreated)
                .Take(count)
                .ToListAsync();
        }

        public async Task<List<Notification>> GetAllNotificationsAsync(string userId)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            return await context.Notification
                .Where(n => n.AppUserId == userId)
                .OrderByDescending(n => n.DateCreated)
                .ToListAsync();
        }

        public async Task<int> GetUnreadCountAsync(string userId)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            return await context.Notification
                .Where(n => n.AppUserId == userId && !n.IsRead)
                .CountAsync();
        }

        public async Task MarkAsReadAsync(int notificationId)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var notification = await context.Notification.FindAsync(notificationId);
            if (notification != null && !notification.IsRead)
            {
                notification.IsRead = true;
                notification.ReadAt = DateTime.Now;
                notification.DateUpdated = DateTime.Now;
                await context.SaveChangesAsync();
            }
        }

        public async Task MarkAllAsReadAsync(string userId)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var unreadNotifications = await context.Notification
                .Where(n => n.AppUserId == userId && !n.IsRead)
                .ToListAsync();

            foreach (var notification in unreadNotifications)
            {
                notification.IsRead = true;
                notification.ReadAt = DateTime.Now;
                notification.DateUpdated = DateTime.Now;
            }

            await context.SaveChangesAsync();
        }

        public async Task DeleteNotificationAsync(int notificationId)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var notification = await context.Notification.FindAsync(notificationId);
            if (notification != null)
            {
                context.Notification.Remove(notification);
                await context.SaveChangesAsync();
            }
        }

        // Specific notification creators
        public async Task NotifyBudgetAlertAsync(string userId, string categoryName, decimal spent, decimal limit, decimal percentage)
        {
            var title = $"⚠️ Budget Alert: {categoryName}";
            var message = $"You've used {percentage:F0}% (${spent:N2} of ${limit:N2}) of your {categoryName} budget.";
            var priority = percentage >= 90 ? "High" : "Normal";

            await CreateNotificationAsync(
                userId,
                title,
                message,
                "Budget",
                "⚠️",
                "/budgets",
                priority);
        }

        public async Task NotifyGoalProgressAsync(string userId, string goalName, decimal current, decimal target, decimal percentage)
        {
            var title = $"🎯 Goal Update: {goalName}";
            var message = $"You're {percentage:F0}% of the way there! ${current:N2} of ${target:N2}";

            await CreateNotificationAsync(
                userId,
                title,
                message,
                "Goal",
                "🎯",
                "/goals");
        }

        public async Task NotifyTransactionAddedAsync(string userId, string description, decimal amount, string type)
        {
            var icon = type == "Income" ? "💰" : "💸";
            var title = $"{icon} {type} Added";
            var message = $"{description}: ${amount:N2}";

            await CreateNotificationAsync(
                userId,
                title,
                message,
                "Transaction",
                icon,
                "/transactions",
                "Low");
        }

        public async Task NotifyGoalAchievedAsync(string userId, string goalName, decimal amount)
        {
            var title = $"🎉 Goal Achieved!";
            var message = $"Congratulations! You've reached your {goalName} goal of ${amount:N2}!";

            await CreateNotificationAsync(
                userId,
                title,
                message,
                "Achievement",
                "🎉",
                "/goals",
                "High");
        }

        public async Task NotifyBudgetExceededAsync(string userId, string categoryName, decimal spent, decimal limit)
        {
            var title = $"🚨 Budget Exceeded!";
            var message = $"You've spent ${spent:N2} on {categoryName}, exceeding your ${limit:N2} budget!";

            await CreateNotificationAsync(
                userId,
                title,
                message,
                "Budget",
                "🚨",
                "/budgets",
                "Urgent");
        }

        private string GetDefaultIcon(string type)
        {
            return type switch
            {
                "Budget" => "⚠️",
                "Goal" => "🎯",
                "Transaction" => "💰",
                "Achievement" => "🎉",
                _ => "📢"
            };
        }
    }
}