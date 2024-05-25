using System;

namespace transport_business_project.Classes
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public int YearsOfExperience { get; set; }
        public string Make { get; set; }
        public string PlateNumber { get; set; }

        public Driver()
        {
            Name = string.Empty;
            LicenseNumber = string.Empty;
            Make = string.Empty;
            PlateNumber = string.Empty;
        }

        public Driver(int id, string name, string make, string licenseNumber, int yearsOfExperience, string plateNumber)
        {
            Id = id;
            Name = name;
            LicenseNumber = licenseNumber;
            YearsOfExperience = yearsOfExperience;
            Make = make;
            PlateNumber = plateNumber;
        }
    }
}
