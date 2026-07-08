using MediChain.Core.Enums;

namespace MediChain.Core.Entities;

public class Medicine : BaseEntity
{
    public string MedicineName { get; set; } = string.Empty;

    public string BrandName { get; set; } = string.Empty;

    public string GenericName { get; set; } = string.Empty;

    public string Strength { get; set; } = string.Empty;

    public string DosageForm { get; set; } = string.Empty;

    public string BatchNumber { get; set; } = string.Empty;

    public DateOnly ManufactureDate { get; set; }

    public DateOnly ExpiryDate { get; set; }

    public decimal Price { get; set; }

    public int ManufacturedQuantity { get; set; }

    public int RemainingQuantity { get; set; }

    public MedicineStatus Status { get; set; }

    public Guid ManufacturerId { get; set; }

    public User Manufacturer { get; set; } = null!;

    public Guid CurrentOwnerId { get; set; }

    public User CurrentOwner { get; set; } = null!;

    public ICollection<MedicineUnit> Units { get; set; } = new List<MedicineUnit>();
}