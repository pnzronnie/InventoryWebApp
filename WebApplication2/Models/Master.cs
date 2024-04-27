namespace WebApplication2.Models
{
    public class Master
    {
        public int Id { get; set; }
        public string? NameMaster { get; set; }
        public string? Address { get; set; }
        public string? NumberPhone { get; set; }
        public string TypeSalary { get; set; } = "rate";
        public int Rate { get; set; }
        public ICollection<Order>? Order { get; set; }
    }
}
