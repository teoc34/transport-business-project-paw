using System;

namespace transport_business_project.Classes
{
    internal class Route
    {
        public int RouteID { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public float Distance { get; set; }
        public float EstimatedTime { get; set; }

        public Route()
        {
            StartLocation = string.Empty;
            EndLocation = string.Empty;
        }

        public Route(int routeID, string startLocation, string endLocation, float distance, float estimatedTime)
        {
            RouteID = routeID;
            StartLocation = startLocation;
            EndLocation = endLocation;
            Distance = distance;
            EstimatedTime = estimatedTime;
        }
    }
}
