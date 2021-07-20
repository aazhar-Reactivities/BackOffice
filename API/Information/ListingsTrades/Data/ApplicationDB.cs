using ListingsTrades.Models;
using Microsoft.EntityFrameworkCore;

namespace ListingsTrades.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<PropertyTypes> PropertyTypes { get; set; }
        public DbSet<Conditions> Conditions { get; set; }
        public DbSet<SourceOfBusiness> SourceOfBusiness { get; set; }
        public DbSet<Classifications> Classifications { get; set; }

    }
}