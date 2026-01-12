namespace Project_PiggyPro.Domain
{
    public class Category : BaseDomainModel
    {
        public string? CategoryName { get; set; }
        public string? CategoryType { get; set; }
        public bool IsSystemCategory { get; set; }
        public string? AppUserId { get; set; }  // Changed from int?, nullable for system categories
    }
    
}

