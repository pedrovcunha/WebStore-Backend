using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;

namespace WebStore.Persistence.DbContext
{
    public class StoreDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreDbContext).Assembly);
        }
    }
}
