using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace transport_business_project.Classes
{
    public class Transport
    {
        [Key]
        public int TransportID { get; set; }
        public string Make { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string LicensePlate { get; set; }

        public Transport()
        {
        }

        public Transport(int transportID, string make, DateTime maintenanceDate, string licensePlate)
        {
            TransportID = transportID;
            Make = make;
            MaintenanceDate = maintenanceDate;
            LicensePlate = licensePlate;
        }
    }
}
