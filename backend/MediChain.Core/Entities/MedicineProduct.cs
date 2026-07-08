namespace MediChain.Core.Entities;

public class MedicineProduct : BaseEntity
{
    public string ProductName { get; set; } = string.Empty;

    public string BrandName { get; set; } = string.Empty;

    public string GenericName { get; set; } = string.Empty;

    public string Strength { get; set; } = string.Empty;

    public string DosageForm { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public Guid CreatedByUserId { get; set; }

    public User CreatedByUser { get; set; } = null!;

    public ICollection<MedicineBatch> Batches { get; set; }
        = new List<MedicineBatch>();
}