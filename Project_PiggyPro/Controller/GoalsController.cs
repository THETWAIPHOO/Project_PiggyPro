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
    public class GoalController : ControllerBase
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;

        public GoalController(IDbContextFactory<Project_PiggyProContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        // GET: api/Goal?userName=john@email.com
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Goal>>> GetGoals(string? userName = null, string? status = null)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var query = context.Goal.AsQueryable();

            if (!string.IsNullOrEmpty(userName))
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.UserName == userName);

                if (user == null)
                {
                    return NotFound($"User '{userName}' not found.");
                }

                query = query.Where(g => g.AppUserId == user.Id);
            }

            // Optional filter by status: Active, Completed, Cancelled
            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(g => g.Status == status);
            }

            var goals = await query.ToListAsync();
            return Ok(goals);
        }

        // GET: api/Goal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Goal>> GetGoal(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var goal = await context.Goal.FindAsync(id);

            if (goal == null)
            {
                return NotFound();
            }

            return Ok(goal);
        }

        // POST: api/Goal
        [HttpPost]
        public async Task<ActionResult<Goal>> CreateGoal(Goal goal)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            goal.CurrentAmount = 0;
            goal.Status = "Active";
            goal.DateCreated = DateTime.UtcNow;
            goal.DateUpdated = DateTime.UtcNow;

            context.Goal.Add(goal);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGoal), new { id = goal.Id }, goal);
        }

        // PUT: api/Goal/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGoal(int id, Goal goal)
        {
            if (id != goal.Id)
            {
                return BadRequest("Goal ID mismatch.");
            }

            using var context = await _contextFactory.CreateDbContextAsync();
            var existing = await context.Goal.FindAsync(id);

            if (existing == null)
            {
                return NotFound();
            }

            existing.GoalName = goal.GoalName;
            existing.Description = goal.Description;
            existing.TargetAmount = goal.TargetAmount;
            existing.CurrentAmount = goal.CurrentAmount;
            existing.TargetDate = goal.TargetDate;
            existing.Status = goal.Status;
            existing.Category = goal.Category;
            existing.DateUpdated = DateTime.UtcNow;

            // Auto-complete if target reached
            if (existing.CurrentAmount >= existing.TargetAmount)
            {
                existing.Status = "Completed";
            }

            await context.SaveChangesAsync();

            return Ok(existing);
        }

        // PATCH: api/Goal/5/contribute
        // Adds amount to CurrentAmount without replacing the whole goal
        [HttpPatch("{id}/contribute")]
        public async Task<IActionResult> ContributeToGoal(int id, [FromBody] decimal amount)
        {
            if (amount <= 0)
            {
                return BadRequest("Contribution amount must be greater than 0.");
            }

            using var context = await _contextFactory.CreateDbContextAsync();
            var goal = await context.Goal.FindAsync(id);

            if (goal == null)
            {
                return NotFound();
            }

            if (goal.Status == "Cancelled")
            {
                return BadRequest("Cannot contribute to a cancelled goal.");
            }

            goal.CurrentAmount += amount;
            goal.DateUpdated = DateTime.UtcNow;

            // Auto-complete if target reached
            if (goal.CurrentAmount >= goal.TargetAmount)
            {
                goal.Status = "Completed";
            }

            await context.SaveChangesAsync();

            return Ok(goal);
        }

        // DELETE: api/Goal/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoal(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var goal = await context.Goal.FindAsync(id);

            if (goal == null)
            {
                return NotFound();
            }

            context.Goal.Remove(goal);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}