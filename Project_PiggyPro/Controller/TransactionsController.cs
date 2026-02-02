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
    public class TransactionsController : ControllerBase
    {
        private readonly IDbContextFactory<Project_PiggyProContext> _contextFactory;

        public TransactionsController(IDbContextFactory<Project_PiggyProContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        // GET: api/Transactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var transactions = await context.Transaction
                .Include(t => t.Category)
                .ToListAsync();
            return Ok(transactions);
        }

        // GET: api/Transactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transaction>> GetTransaction(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var transaction = await context.Transaction
                .Include(t => t.Category)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }

        // POST: api/Transactions
        [HttpPost]
        public async Task<ActionResult<Transaction>> CreateTransaction(Transaction transaction)
        {
            using var context = await _contextFactory.CreateDbContextAsync();

            transaction.DateCreated = DateTime.UtcNow;
            transaction.DateUpdated = DateTime.UtcNow;

            context.Transaction.Add(transaction);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTransaction), new { id = transaction.Id }, transaction);
        }

        // PUT: api/Transactions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTransaction(int id, Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return BadRequest("Transaction ID mismatch.");
            }

            using var context = await _contextFactory.CreateDbContextAsync();
            var existing = await context.Transaction.FindAsync(id);

            if (existing == null)
            {
                return NotFound();
            }

            existing.Amount = transaction.Amount;
            existing.TransactionDate = transaction.TransactionDate;
            existing.TransactionType = transaction.TransactionType;
            existing.Description = transaction.Description;
            existing.AppUserId = transaction.AppUserId;
            existing.CategoryId = transaction.CategoryId;
            existing.DateUpdated = DateTime.UtcNow;

            await context.SaveChangesAsync();

            return Ok(existing);
        }

        // DELETE: api/Transactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransaction(int id)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            var transaction = await context.Transaction.FindAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            context.Transaction.Remove(transaction);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}