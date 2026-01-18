using Project_PiggyPro.Data;
using System.ComponentModel.DataAnnotations;

namespace Project_PiggyPro.Domain
{
    public class GoalContribution : BaseDomainModel
    {
        [Required]
        public int GoalId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime ContributionDate { get; set; }

        public string? Notes { get; set; }

        [Required]
        [StringLength(450)]
        public string AppUserId { get; set; } = string.Empty;

        // Navigation properties
        public virtual Goal? Goal { get; set; }
        public virtual Project_PiggyProUser? User { get; set; }
    }
}
