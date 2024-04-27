namespace WebApplication2.Models
{
    public class TypeTechnic
    {
        public int Id { get; set; }
        public string? NameTypeTechnic { get; set; }
        public List<Order>? Order { get; set; }
    }
}
