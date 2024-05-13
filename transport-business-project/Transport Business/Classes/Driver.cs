using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_business_project.Classes
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }

        DateTime HireDate{ get; set; }

        public String LicenseNumber { get; set; }
        public int YearsOfExperience { get; set; }

        public Driver() { }

        public Driver(int id, string name, DateTime hireDate, string licenseNumber, int yearsOfExperience)
        {
            Id = id;
            Name = name;
            HireDate = hireDate;
            LicenseNumber = licenseNumber;
            YearsOfExperience = yearsOfExperience;
        }
    }
}
