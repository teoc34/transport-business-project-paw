using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_business_project.Classes
{
    internal class Route
    {
        public int routeID { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public float Distance { get; set; }
        public float EstimatedTime { get; set; }

        public Route() { }

        public Route(int routeID, string startLocation, string endLocation, float distance, float estimatedTime)
        {
            this.routeID = routeID;
            StartLocation = startLocation;
            EndLocation = endLocation;
            Distance = distance;
            EstimatedTime = estimatedTime;
        }
    }
}
