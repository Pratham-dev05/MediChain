using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using MediChain.Infrastructure.Configurations;

namespace MediChain.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<User> Users => Set<User>();

    public DbSet<MedicineProduct> MedicineProducts => Set<MedicineProduct>();

    public DbSet<MedicineBatch> MedicineBatches => Set<MedicineBatch>();

    public DbSet<MedicineUnit> MedicineUnits => Set<MedicineUnit>();

    public DbSet<OwnershipHistory> OwnershipHistories => Set<OwnershipHistory>();

    public DbSet<FakeReport> FakeReports => Set<FakeReport>();

    public DbSet<VerificationLog> VerificationLogs => Set<VerificationLog>();

    public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.ApplyConfiguration(new UserConfiguration());
    modelBuilder.ApplyConfiguration(new MedicineProductConfiguration());
    modelBuilder.ApplyConfiguration(new MedicineBatchConfiguration());
    modelBuilder.ApplyConfiguration(new MedicineUnitConfiguration());
    modelBuilder.ApplyConfiguration(new OwnershipHistoryConfiguration());
    modelBuilder.ApplyConfiguration(new FakeReportConfiguration());
    modelBuilder.ApplyConfiguration(new VerificationLogConfiguration());
    modelBuilder.ApplyConfiguration(new AuditLogConfiguration());
}
}