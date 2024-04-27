using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Master> Masters => Set<Master>();
        public DbSet<TypeTechnic> TypeTechnices => Set<TypeTechnic>();
        public DbSet<BrandTechnic> BrandTechnices => Set<BrandTechnic>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Details> Details => Set<Details>();

    }
}
