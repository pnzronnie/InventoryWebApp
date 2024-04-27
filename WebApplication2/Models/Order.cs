namespace WebApplication2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public int MasterId { get; set; }
        public Master? Master { get; set; }
        public string? DateCreation { get; set; }
        public string? DateCompleted { get; set; }
        public string? DateIssue { get; set; }
        public int TypeTechnicId { get; set; }
        public TypeTechnic? TypeTechnic { get; set; }
        public int BrandTechnicId { get; set; }
        public BrandTechnic? BrandTechnic { get; set; }
        public string? ModelTechnic { get; set; }
        public string? FactoryNumber { get; set; }
        public string? Equipment { get; set; }
        public string? Diagnosis { get; set; }
        public string? Note { get; set; }
        public bool UrgentRepairs { get; set; }
        public bool InProgress { get; set; }
        public int Guarantee { get; set; }
        public string? DateEndGuarantee { get; set; }
        public bool Deleted { get; set; }
        public bool ReturnUnderGuarantee { get; set; }
        public bool Issue { get; set; }
        public int PriceRepair { get; set; }
        public string? FoundProblem { get; set; }
    }
}
