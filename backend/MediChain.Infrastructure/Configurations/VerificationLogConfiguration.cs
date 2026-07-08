using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediChain.Infrastructure.Configurations;

public class VerificationLogConfiguration : IEntityTypeConfiguration<VerificationLog>
{
    public void Configure(EntityTypeBuilder<VerificationLog> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.MedicineUnit)
            .WithMany(x => x.VerificationLogs)
            .HasForeignKey(x => x.MedicineUnitId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.VerifiedByUser)
            .WithMany(x => x.VerificationLogs)
            .HasForeignKey(x => x.VerifiedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}