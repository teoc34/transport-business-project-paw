using System;
using System.Collections.Generic;

namespace transport_business_project.Classes
{
    public class Transport
    {
        public int TransportID { get; set; }
        public string Make { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string LicensePlate { get; set; }
        public List<string> Types { get; set; }

        public Transport()
        {
            Make = string.Empty;
            LicensePlate = string.Empty;
            Types = new List<string>();
        }

        public Transport(int transportID, string make, DateTime maintenanceDate, string licensePlate, List<string> types)
        {
            TransportID = transportID;
            Make = make;
            MaintenanceDate = maintenanceDate;
            LicensePlate = licensePlate;
            Types = types;
        }
    }
}
