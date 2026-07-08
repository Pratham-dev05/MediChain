using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediChain.Infrastructure.Configurations;

public class MedicineBatchConfiguration : IEntityTypeConfiguration<MedicineBatch>
{
    public void Configure(EntityTypeBuilder<MedicineBatch> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Product)
            .WithMany(x => x.Batches)
            .HasForeignKey(x => x.ProductId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Manufacturer)
            .WithMany(x => x.ManufacturedBatches)
            .HasForeignKey(x => x.ManufacturerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}