
using GoogleMapsApi.Entities.Common;

namespace YardSale.Models
{

    public class MapModel
    {
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Location GeoCode { get; set; }
        public string Key { get; set; }

        public string GetAPIKey()
        {
            return "";
        }

        public Location GetGeoCode()
        {

        }
    }
}