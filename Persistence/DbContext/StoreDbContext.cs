using System;
using System.Threading;
using System.Threading.Tasks;
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

            modelBuilder.Entity<Basket>().HasData(
                new Basket
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Buyer = "Pedro",
                    OnlineStoreDomainRegion = "Australia"

                },
                new Basket
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    Buyer = "David",
                    OnlineStoreDomainRegion = "Europe"

                },
                new Basket
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Buyer = "Stuart",
                    OnlineStoreDomainRegion = "US"

                },
                new Basket
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    Buyer = "Frances",
                    OnlineStoreDomainRegion = "Europe"

                },
                new Basket
                {
                    Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                    Buyer = "Lin",
                    OnlineStoreDomainRegion = "Us"

                },
                new Basket
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                    Buyer = "Meghan",
                    OnlineStoreDomainRegion = "Europe"

                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid(),
                    Category = "Liquor",
                    Name = "RedWine A",
                    Description = "Cabernet Sauvignon",
                    UnitPrice = 35.22M,
                    BasketId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Category = "Liquor",
                    Name = "Red Wine B",
                    Description = "Shiraz",
                    UnitPrice = 22.0M,
                    BasketId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Category = "Liquor",
                    Name = "Red Wine C",
                    Description = "Cabernet Sauvignon",
                    UnitPrice = 15.3M,
                    BasketId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Category = "Liquor",
                    Name = "Red Wine D",
                    Description = "Pinot Noir",
                    UnitPrice = 45.5M,
                    BasketId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Category = "Liquor",
                    Name = "Red Wine E",
                    Description = "Pinot Noir",
                    UnitPrice = 33.1M,
                    BasketId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                }
                
            );
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
