namespace MediChain.Core.Entities;

public class MedicineUnit : BaseEntity
{
    public Guid BatchId { get; set; }

    public MedicineBatch Batch { get; set; } = null!;

    public string QRCode { get; set; } = string.Empty;

    public string BlockchainHash { get; set; } = string.Empty;
    public Guid CurrentOwnerId { get; set; }

    public User CurrentOwner { get; set; } = null!;

    public int VerificationCount { get; set; }

    public DateTime? LastVerifiedAt { get; set; }
    public bool IsSold { get; set; }

    public bool IsReportedFake { get; set; }

    // Navigation Properties

    public ICollection<OwnershipHistory> OwnershipHistories { get; set; }
        = new List<OwnershipHistory>();

    public ICollection<FakeReport> FakeReports { get; set; }
        = new List<FakeReport>();

    public ICollection<VerificationLog> VerificationLogs { get; set; }
    = new List<VerificationLog>();
        
}