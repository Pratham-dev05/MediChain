namespace MediChain.Core.Enums;

public enum TransferType
{
    ManufacturerToDistributor = 1,
    DistributorToPharmacy = 2,
    PharmacyToCustomer = 3,
    CustomerReturn = 4,
    Recall = 5
}