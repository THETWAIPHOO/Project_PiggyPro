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
    public class CategoryController : ControllerBase
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;

        public CategoryController(IDbContextFactory<Project_PiggyProContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        // GET: api/Category
        // ?userName=john@email.com → returns user's categories + system categories
        // ?systemOnly=true → returns only system categories
        // No params → returns all categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories(string? userName = null, bool systemOnly = false)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            var query = context.Category.AsQueryable();

            if (systemOnly)
            {
                query = query.Where(c => c.IsSystemCategory);
            }
            else if (!string.IsNullOrEmpty(userName))
            {
                var user = await context.Users.FirstOrDefaultAsync(u => u.UserName == userName);

                if (user == null)
                {
                    return NotFound($"User '{userName}' not found.");
                }

                // Return user's own categories + system categories
                query = query.Where(c => c.AppUserId == user.Id || c.IsSystemCategory);
            }

            var categories = await query.ToListAsync();
            return Ok(categories);
        }

        // GET: api/Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var category = await context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        // POST: api/Category
        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            category.DateCreated = DateTime.UtcNow;
            category.DateUpdated = DateTime.UtcNow;

            context.Category.Add(category);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest("Category ID mismatch.");
            }

            using var context = await _contextFactory.CreateDbContextAsync();
            var existing = await context.Category.FindAsync(id);

            if (existing == null)
            {
                return NotFound();
            }

            // Prevent editing system categories
            if (existing.IsSystemCategory)
            {
                return BadRequest("Cannot modify system categories.");
            }

            existing.CategoryName = category.CategoryName;
            existing.CategoryType = category.CategoryType;
            existing.AppUserId = category.AppUserId;
            existing.DateUpdated = DateTime.UtcNow;

            await context.SaveChangesAsync();

            return Ok(existing);
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var category = await context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            // Prevent deleting system categories
            if (category.IsSystemCategory)
            {
                return BadRequest("Cannot delete system categories.");
            }

            context.Category.Remove(category);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}