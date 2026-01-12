namespace Project_PiggyPro.Domain
{
    public class Goal : BaseDomainModel
    {
        public string? GoalName { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime TargetDate { get; set; }
        public string? GoalStatus { get; set; }
        public string AppUserId { get; set; } = string.Empty;

    }
    
}
