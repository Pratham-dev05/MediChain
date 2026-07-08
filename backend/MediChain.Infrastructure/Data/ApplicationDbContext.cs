using MediChain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediChain.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    public DbSet<Medicine> Medicines => Set<Medicine>();

    public DbSet<MedicineUnit> MedicineUnits => Set<MedicineUnit>();
}