using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Data;

namespace Project_PiggyPro.Services
{
    public class ReportsService
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;

        public ReportsService(IDbContextFactory<Project_PiggyProContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        // Get spending statistics for a user
        public async Task<SpendingStatsDto> GetSpendingStatsAsync(string userId, int days = 30)
        {
            using var context = _contextFactory.CreateDbContext();

            var startDate = DateTime.UtcNow.AddDays(-days);

            // Get all expenses in the period - JOIN with Category table manually
            var expenses = await context.Transaction
                .Join(context.Category,
                    t => t.CategoryId,
                    c => c.Id,
                    (t, c) => new { Transaction = t, CategoryName = c.CategoryName })
                .Where(x => x.Transaction.AppUserId == userId &&
                           x.Transaction.TransactionType == "Expense" &&
                           x.Transaction.TransactionDate >= startDate)
                .ToListAsync();

            // Get all income in the period
            var income = await context.Transaction
                .Where(t => t.AppUserId == userId &&
                           t.TransactionType == "Income" &&
                           t.TransactionDate >= startDate)
                .ToListAsync();

            var totalExpenses = expenses.Sum(x => x.Transaction.Amount);
            var totalIncome = income.Sum(t => t.Amount);
            var averageDaily = expenses.Any() ? totalExpenses / days : 0;
            var savingsRate = totalIncome > 0 ? ((totalIncome - totalExpenses) / totalIncome) * 100 : 0;

            // Get top spending category
            var topCategory = expenses
                .GroupBy(x => x.CategoryName)
                .OrderByDescending(g => g.Sum(x => x.Transaction.Amount))
                .FirstOrDefault();

            return new SpendingStatsDto
            {
                AverageDailySpending = averageDaily,
                TopSpendingCategory = topCategory?.Key ?? "N/A",
                TopCategoryAmount = topCategory?.Sum(x => x.Transaction.Amount) ?? 0,
                SavingsRate = savingsRate,
                TotalIncome = totalIncome,
                TotalExpenses = totalExpenses
            };
        }

        // Get income vs expenses data for chart
        public async Task<IncomeVsExpensesDto> GetIncomeVsExpensesAsync(string userId, int months = 6)
        {
            using var context = _contextFactory.CreateDbContext();

            var startDate = DateTime.UtcNow.AddMonths(-months).Date;
            var labels = new List<string>();
            var incomeData = new List<decimal>();
            var expenseData = new List<decimal>();

            for (int i = months - 1; i >= 0; i--)
            {
                var date = DateTime.UtcNow.AddMonths(-i);
                var monthStart = new DateTime(date.Year, date.Month, 1);
                var monthEnd = monthStart.AddMonths(1).AddDays(-1);

                var monthIncome = await context.Transaction
                    .Where(t => t.AppUserId == userId &&
                               t.TransactionType == "Income" &&
                               t.TransactionDate >= monthStart &&
                               t.TransactionDate <= monthEnd)
                    .SumAsync(t => (decimal?)t.Amount) ?? 0;

                var monthExpenses = await context.Transaction
                    .Where(t => t.AppUserId == userId &&
                               t.TransactionType == "Expense" &&
                               t.TransactionDate >= monthStart &&
                               t.TransactionDate <= monthEnd)
                    .SumAsync(t => (decimal?)t.Amount) ?? 0;

                labels.Add(date.ToString("MMM yyyy"));
                incomeData.Add(monthIncome);
                expenseData.Add(monthExpenses);
            }

            return new IncomeVsExpensesDto
            {
                Labels = labels,
                IncomeData = incomeData,
                ExpenseData = expenseData
            };
        }

        // Get expense breakdown by category
        public async Task<ExpenseBreakdownDto> GetExpenseBreakdownAsync(string userId, int days = 30)
        {
            using var context = _contextFactory.CreateDbContext();

            var startDate = DateTime.UtcNow.AddDays(-days);

            // Manual JOIN with Category
            var categoryTotals = await context.Transaction
                .Join(context.Category,
                    t => t.CategoryId,
                    c => c.Id,
                    (t, c) => new { Transaction = t, CategoryName = c.CategoryName })
                .Where(x => x.Transaction.AppUserId == userId &&
                           x.Transaction.TransactionType == "Expense" &&
                           x.Transaction.TransactionDate >= startDate)
                .GroupBy(x => x.CategoryName)
                .Select(g => new CategoryAmount
                {
                    Category = g.Key,
                    Amount = g.Sum(x => x.Transaction.Amount)
                })
                .OrderByDescending(c => c.Amount)
                .ToListAsync();

            return new ExpenseBreakdownDto
            {
                Categories = categoryTotals.Select(c => c.Category).ToList(),
                Amounts = categoryTotals.Select(c => c.Amount).ToList()
            };
        }

        // Get spending trend over time
        public async Task<SpendingTrendDto> GetSpendingTrendAsync(string userId, int days = 30)
        {
            using var context = _contextFactory.CreateDbContext();

            var startDate = DateTime.UtcNow.AddDays(-days).Date;
            var labels = new List<string>();
            var data = new List<decimal>();

            for (int i = days - 1; i >= 0; i--)
            {
                var date = DateTime.UtcNow.AddDays(-i).Date;

                var dayExpenses = await context.Transaction
                    .Where(t => t.AppUserId == userId &&
                               t.TransactionType == "Expense" &&
                               t.TransactionDate.Date == date)
                    .SumAsync(t => (decimal?)t.Amount) ?? 0;

                labels.Add(date.ToString("MMM dd"));
                data.Add(dayExpenses);
            }

            return new SpendingTrendDto
            {
                Labels = labels,
                Data = data
            };
        }

        // Get all transactions for CSV export
        public async Task<List<TransactionExportDto>> GetTransactionsForExportAsync(string userId, int days = 30)
        {
            using var context = _contextFactory.CreateDbContext();

            var startDate = DateTime.UtcNow.AddDays(-days);

            // Manual JOIN with Category
            return await context.Transaction
                .Join(context.Category,
                    t => t.CategoryId,
                    c => c.Id,
                    (t, c) => new { Transaction = t, CategoryName = c.CategoryName })
                .Where(x => x.Transaction.AppUserId == userId &&
                           x.Transaction.TransactionDate >= startDate)
                .OrderByDescending(x => x.Transaction.TransactionDate)
                .Select(x => new TransactionExportDto
                {
                    Date = x.Transaction.TransactionDate,
                    Type = x.Transaction.TransactionType,
                    Category = x.CategoryName,
                    Amount = x.Transaction.Amount,
                    Description = x.Transaction.Description ?? ""
                })
                .ToListAsync();
        }
    }

    // ============= DTOs =============

    public class SpendingStatsDto
    {
        public decimal AverageDailySpending { get; set; }
        public string TopSpendingCategory { get; set; } = "";
        public decimal TopCategoryAmount { get; set; }
        public decimal SavingsRate { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
    }

    public class IncomeVsExpensesDto
    {
        public List<string> Labels { get; set; } = new();
        public List<decimal> IncomeData { get; set; } = new();
        public List<decimal> ExpenseData { get; set; } = new();
    }

    public class ExpenseBreakdownDto
    {
        public List<string> Categories { get; set; } = new();
        public List<decimal> Amounts { get; set; } = new();
    }

    public class SpendingTrendDto
    {
        public List<string> Labels { get; set; } = new();
        public List<decimal> Data { get; set; } = new();
    }

    public class CategoryAmount
    {
        public string Category { get; set; } = "";
        public decimal Amount { get; set; }
    }

    public class TransactionExportDto
    {
        public DateTime Date { get; set; }
        public string Type { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";  // ✅ ADDED THIS
    }
}