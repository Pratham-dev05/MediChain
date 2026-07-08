using MediChain.Core.Enums;

namespace MediChain.Core.Entities;

public class MedicineBatch : BaseEntity
{
    public Guid ProductId { get; set; }

    public MedicineProduct Product { get; set; } = null!;

    public string BatchNumber { get; set; } = string.Empty;

    public DateOnly ManufactureDate { get; set; }

    public DateOnly ExpiryDate { get; set; }

    public int ManufacturedQuantity { get; set; }

    public int RemainingQuantity { get; set; }

    public MedicineStatus Status { get; set; }

    public Guid ManufacturerId { get; set; }

    public User Manufacturer { get; set; } = null!;

    public ICollection<MedicineUnit> Units { get; set; }
        = new List<MedicineUnit>();
}