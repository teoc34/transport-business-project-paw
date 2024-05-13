using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_business_project.Classes
{
    public class Transport
    {
        public int TransportID { get; set; }
        public float Capacity { get; set; }
        DateTime MaintenanceDate { get; set; }

        public List<Type> Type { get; set; }

        public Transport()
        {
            Type = new List<Type>();
        }

        public Transport(int transportID, float capacity, DateTime maintenanceDate)
        {
            TransportID = transportID;
            Capacity = capacity;
            MaintenanceDate = maintenanceDate;
        }
    }

}
