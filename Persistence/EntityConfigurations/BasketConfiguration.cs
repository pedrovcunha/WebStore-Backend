using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Domain.Entities;

namespace WebStore.Persistence.EntityConfigurations
{
    public class BasketConfiguration: IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedOn)
                .HasColumnType("datetime2(0)")
                .HasDefaultValueSql("(sysutcdatetime())");

            builder.HasMany(x => x.Products)
                .WithOne(x => x.Basket)
                .HasForeignKey(x => x.BasketId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
