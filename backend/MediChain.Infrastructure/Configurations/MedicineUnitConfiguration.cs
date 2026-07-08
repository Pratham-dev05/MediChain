using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediChain.Infrastructure.Configurations;

public class MedicineUnitConfiguration : IEntityTypeConfiguration<MedicineUnit>
{
    public void Configure(EntityTypeBuilder<MedicineUnit> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Batch)
            .WithMany(x => x.Units)
            .HasForeignKey(x => x.BatchId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.CurrentOwner)
            .WithMany(x => x.OwnedMedicineUnits)
            .HasForeignKey(x => x.CurrentOwnerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}