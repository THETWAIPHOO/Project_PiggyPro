using System.ComponentModel.DataAnnotations.Schema;

namespace Project_PiggyPro.Domain
{
    public class Budget : BaseDomainModel
    {
        public double BudgetAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? BudgetPeriod { get; set; }
        public string RuleName { get; set; } = "50/30/20"; // or "Custom"
        public decimal NeedsPercentage { get; set; } = 50;
        public decimal WantsPercentage { get; set; } = 30;
        public decimal SavingsPercentage { get; set; } = 20;
        public string? BucketType { get; set; }
        public decimal AllocatedAmount { get; set; }
        public string AppUserId { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

    }

   
}

