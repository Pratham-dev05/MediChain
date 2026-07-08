namespace MediChain.Core.Entities;

public class MedicineUnit : BaseEntity
{
    public Guid MedicineId { get; set; }

    public Medicine Medicine { get; set; } = null!;

    public string QRCode { get; set; } = string.Empty;

    public string BlockchainHash { get; set; } = string.Empty;

    public bool IsSold { get; set; }

    public bool IsReportedFake { get; set; }
}