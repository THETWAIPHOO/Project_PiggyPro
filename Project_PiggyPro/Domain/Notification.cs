namespace Project_PiggyPro.Domain
{
    public class Notification : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Message { get; set; }
        public string? NotificationType { get; set; }

        public string AppUserId { get; set; } = string.Empty;
    }
    
}
