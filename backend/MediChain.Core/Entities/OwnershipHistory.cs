using MediChain.Core.Enums;

namespace MediChain.Core.Entities;

public class OwnershipHistory : BaseEntity
{
    public Guid MedicineUnitId { get; set; }

    public MedicineUnit MedicineUnit { get; set; } = null!;

    public Guid FromUserId { get; set; }

    public User FromUser { get; set; } = null!;

    public Guid ToUserId { get; set; }

    public User ToUser { get; set; } = null!;

    public TransferType TransferType { get; set; }

    public string TransactionHash { get; set; } = string.Empty;

    public DateTime TransferDate { get; set; } = DateTime.UtcNow;
}