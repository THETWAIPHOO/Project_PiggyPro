using System.ComponentModel.DataAnnotations;
using Project_PiggyPro.Data;

namespace Project_PiggyPro.Domain
{
    public class Goal : BaseDomainModel
    {
        [Required]
        [StringLength(100)]
        public string GoalName { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Target amount must be greater than 0")]
        public decimal TargetAmount { get; set; }

        [Range(0, double.MaxValue)]
        public decimal CurrentAmount { get; set; } = 0;

        [Required]
        public DateTime TargetDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; } = "Active"; // Active, Completed, Cancelled

        [StringLength(50)]
        public string? Category { get; set; } // Electronics, Travel, Emergency Fund, etc.

        [Required]
        public string AppUserId { get; set; } = string.Empty;

        // Navigation property
        public virtual Project_PiggyProUser? AppUser { get; set; }

        // Computed properties
        public decimal ProgressPercentage => TargetAmount > 0 ? (CurrentAmount / TargetAmount) * 100 : 0;
        public decimal RemainingAmount => TargetAmount - CurrentAmount;
        public int DaysRemaining => (TargetDate - DateTime.Today).Days;
        public bool IsCompleted => CurrentAmount >= TargetAmount;
        public bool IsOverdue => DateTime.Today > TargetDate && !IsCompleted;
    }
}