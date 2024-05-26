using System.ComponentModel.DataAnnotations;

namespace transport_business_project.Classes
{
    public class Route
    {
        [Key]
        public int RouteID { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public float Distance { get; set; }
        public float EstimatedTime { get; set; }

        public Route() { }

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
