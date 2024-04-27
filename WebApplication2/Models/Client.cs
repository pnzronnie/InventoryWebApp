namespace WebApplication2.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? NameClient { get; set; }
        public string? Address { get; set; }
        public string? NumberPhoneWork { get; set; }
        public string? NumberPhoneHome { get; set; }
        public string TypeClient { get; set; } = "normal";
        public List<Order>? Order { get; set; }
    }
}
