using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediChain.Infrastructure.Configurations;

public class OwnershipHistoryConfiguration : IEntityTypeConfiguration<OwnershipHistory>
{
    public void Configure(EntityTypeBuilder<OwnershipHistory> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .HasOne(x => x.FromUser)
            .WithMany(x => x.TransfersFrom)
            .HasForeignKey(x => x.FromUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.ToUser)
            .WithMany(x => x.TransfersTo)
            .HasForeignKey(x => x.ToUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.MedicineUnit)
            .WithMany(x => x.OwnershipHistories)
            .HasForeignKey(x => x.MedicineUnitId);
    }
}