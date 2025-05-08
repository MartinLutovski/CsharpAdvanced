using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Models
{
    public class Car : BaseEntity
    {

        public Car() 
        {

        }

        public Car(string model, string licensePlate, DateTime licenseExpiryDate)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicenseExpiryDate = licenseExpiryDate;
            DriversAssigned = new List<Driver>();
        }


        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public List<Driver> DriversAssigned { get; set; }

        public override string Print()
        {
            int assignedPercent = DriversAssigned.Count == 0 ? 0 : 100 / 3 * DriversAssigned.Count + 1;
            return $"{Id}) {Model} with license Plate:{LicensePlate} and utilized {assignedPercent}%";
        }

        public ExpiryStatus IsLicenseExpired()
        {
            if (DateTime.Today >= LicenseExpiryDate)
                return ExpiryStatus.Expired;
            else if (DateTime.Today.AddMonths(3) >= LicenseExpiryDate)
                return ExpiryStatus.Warning;
            else
                return ExpiryStatus.Valid;
        }

    }
}
