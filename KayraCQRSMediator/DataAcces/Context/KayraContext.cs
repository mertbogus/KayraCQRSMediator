using KayraCQRSMediator.DataAcces.Entities;
using Microsoft.EntityFrameworkCore;

namespace KayraCQRSMediator.DataAcces.Context
{
    public class KayraContext : DbContext
    {
        public KayraContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category > Categories { get; set; }
        public DbSet<Product > Products { get; set; }

      
    }
}
