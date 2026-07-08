using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediChain.Infrastructure.Configurations;

public class MedicineProductConfiguration : IEntityTypeConfiguration<MedicineProduct>
{
    public void Configure(EntityTypeBuilder<MedicineProduct> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.CreatedByUser)
            .WithMany(x => x.CreatedProducts)
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}