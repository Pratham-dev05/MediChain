using MediChain.Core.Enums;

namespace MediChain.Core.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public UserRole Role { get; set; }

    public bool IsActive { get; set; } = true;

    // Products created by manufacturer
    public ICollection<MedicineProduct> CreatedProducts { get; set; }
        = new List<MedicineProduct>();

    // Batches manufactured
    public ICollection<MedicineBatch> ManufacturedBatches { get; set; }
        = new List<MedicineBatch>();

    // Units currently owned
    public ICollection<MedicineUnit> OwnedMedicineUnits { get; set; }
        = new List<MedicineUnit>();

    // Ownership history
    public ICollection<OwnershipHistory> TransfersFrom { get; set; }
        = new List<OwnershipHistory>();

    public ICollection<OwnershipHistory> TransfersTo { get; set; }
        = new List<OwnershipHistory>();

    // Fake reports
    public ICollection<FakeReport> FakeReports { get; set; }
        = new List<FakeReport>();

    // Verification history
    public ICollection<VerificationLog> VerificationLogs { get; set; }
        = new List<VerificationLog>();

    // Audit logs
    public ICollection<AuditLog> AuditLogs { get; set; }
        = new List<AuditLog>();
}