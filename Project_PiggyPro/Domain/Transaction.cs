using System.ComponentModel.DataAnnotations.Schema;

namespace Project_PiggyPro.Domain
{
    public class Transaction : BaseDomainModel
    {
        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public string? TransactionType { get; set; }
        public string? Description { get; set; }
        public string AppUserId { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}
