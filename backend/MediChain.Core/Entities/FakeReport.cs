using MediChain.Core.Enums;

namespace MediChain.Core.Entities;

public class FakeReport : BaseEntity
{
    public Guid MedicineUnitId { get; set; }

    public MedicineUnit MedicineUnit { get; set; } = null!;

    public Guid ReportedByUserId { get; set; }

    public User ReportedByUser { get; set; } = null!;

    public string Reason { get; set; } = string.Empty;

    public ReportStatus Status { get; set; } = ReportStatus.Pending;

    public DateTime ReportedAt { get; set; } = DateTime.UtcNow;
}