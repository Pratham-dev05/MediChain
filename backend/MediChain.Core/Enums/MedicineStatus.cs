namespace MediChain.Core.Enums;

public enum MedicineStatus
{
    Manufactured = 1,
    InTransit = 2,
    AtDistributor = 3,
    AtPharmacy = 4,
    Sold = 5,
    Recalled = 6,
    ReportedFake = 7
}