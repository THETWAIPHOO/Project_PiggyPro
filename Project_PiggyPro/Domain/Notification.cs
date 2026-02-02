namespace Project_PiggyPro.Domain
{
    public class Notification : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Message { get; set; }
        public string? NotificationType { get; set; } // "Budget", "Goal", "Transaction", "Achievement"
        public string? Icon { get; set; } // Emoji or icon class
        public string? ActionUrl { get; set; } // Link to relevant page

        // Status
        public bool IsRead { get; set; } = false;
        public DateTime? ReadAt { get; set; }

        // Priority
        public string Priority { get; set; } = "Normal"; // "Low", "Normal", "High", "Urgent"

        // Related entity (optional)
        public int? RelatedEntityId { get; set; } // ID of budget, goal, or transaction
        public string? RelatedEntityType { get; set; } // "Budget", "Goal", "Transaction"

        // User reference
        public string AppUserId { get; set; } = string.Empty;
    }
}


































