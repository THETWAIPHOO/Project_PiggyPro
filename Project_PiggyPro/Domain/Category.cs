namespace Project_PiggyPro.Domain
{
    public class Category : BaseDomainModel
    {
        public string? CategoryName { get; set; }
        public string? CategoryType { get; set; }

        public int AppUserId { get; set; }
    }
    
}

