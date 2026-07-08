using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediChain.Infrastructure.Configurations;

public class FakeReportConfiguration : IEntityTypeConfiguration<FakeReport>
{
    public void Configure(EntityTypeBuilder<FakeReport> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.MedicineUnit)
            .WithMany(x => x.FakeReports)
            .HasForeignKey(x => x.MedicineUnitId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.ReportedByUser)
            .WithMany(x => x.FakeReports)
            .HasForeignKey(x => x.ReportedByUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}