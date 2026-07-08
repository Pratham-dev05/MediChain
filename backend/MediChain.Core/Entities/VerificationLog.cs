namespace MediChain.Core.Entities;

public class VerificationLog : BaseEntity
{
    public Guid MedicineUnitId { get; set; }

    public MedicineUnit MedicineUnit { get; set; } = null!;

    public Guid VerifiedByUserId { get; set; }

    public User VerifiedByUser { get; set; } = null!;

    public DateTime VerifiedAt { get; set; } = DateTime.UtcNow;

    public string VerificationResult { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string IPAddress { get; set; } = string.Empty;
}