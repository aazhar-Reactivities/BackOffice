using Microsoft.EntityFrameworkCore;

namespace ListingsTrades.Data
{
    public class ListingsTradesContext : DbContext
    {
        public ListingsTradesContext(DbContextOptions<ListingsTradesContext> options) : base(options)
        {
            
        }

        public DbSet<PropertyTypes> PropertyTypes { get; set; }
        public DbSet<Conditions> Conditions { get; set; }
        public DbSet<SourceOfBusiness> SourceOfBusiness { get; set; }
        public DbSet<Classifications> Classifications { get; set; }

    }
}