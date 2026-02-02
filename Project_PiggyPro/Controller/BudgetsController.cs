using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_PiggyPro.Data;
using Project_PiggyPro.Domain;

namespace Project_PiggyPro.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetController : ControllerBase
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;

        public BudgetController(IDbContextFactory<Project_PiggyProContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        // GET: api/Budget?userName=john@email.com
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Budget>>> GetBudgets(string? userName = null)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var query = context.Budget.Include(b => b.Category).AsQueryable();

            if (!string.IsNullOrEmpty(userName))
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.UserName == userName);

                if (user == null)
                {
                    return NotFound($"User '{userName}' not found.");
                }

                query = query.Where(b => b.AppUserId == user.Id);
            }

            var budgets = await query.ToListAsync();
            return Ok(budgets);
        }

        // GET: api/Budget/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Budget>> GetBudget(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var budget = await context.Budget
                .Include(b => b.Category)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (budget == null)
            {
                return NotFound();
            }

            return Ok(budget);
        }

        // POST: api/Budget
        [HttpPost]
        public async Task<ActionResult<Budget>> CreateBudget(Budget budget)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            budget.DateCreated = DateTime.UtcNow;
            budget.DateUpdated = DateTime.UtcNow;

            context.Budget.Add(budget);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBudget), new { id = budget.Id }, budget);
        }

        // PUT: api/Budget/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBudget(int id, Budget budget)
        {
            if (id != budget.Id)
            {
                return BadRequest("Budget ID mismatch.");
            }

            using var context = await _contextFactory.CreateDbContextAsync();
            var existing = await context.Budget.FindAsync(id);

            if (existing == null)
            {
                return NotFound();
            }

            existing.BudgetAmount = budget.BudgetAmount;
            existing.StartDate = budget.StartDate;
            existing.EndDate = budget.EndDate;
            existing.BudgetPeriod = budget.BudgetPeriod;
            existing.RuleName = budget.RuleName;
            existing.NeedsPercentage = budget.NeedsPercentage;
            existing.WantsPercentage = budget.WantsPercentage;
            existing.SavingsPercentage = budget.SavingsPercentage;
            existing.BucketType = budget.BucketType;
            existing.AllocatedAmount = budget.AllocatedAmount;
            existing.AppUserId = budget.AppUserId;
            existing.CategoryId = budget.CategoryId;
            existing.DateUpdated = DateTime.UtcNow;

            await context.SaveChangesAsync();

            return Ok(existing);
        }

        // DELETE: api/Budget/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBudget(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var budget = await context.Budget.FindAsync(id);

            if (budget == null)
            {
                return NotFound();
            }

            context.Budget.Remove(budget);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}