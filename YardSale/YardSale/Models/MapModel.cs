using YardSale.Models.CRUD;
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

        public string GetMapKey()
        {
            return "";
            //DatabaseModel db = new DatabaseModel();
            //return db.GetGoogleMapApiKey();
        }

        public string GetGeoCodeKey()
        {
            return "";
            //DatabaseModel db = new DatabaseModel();
            //return db.GetGeocodingKey();
        }

        public Location GetGeoCode()
        {
            Location loc = new Location(0,0);
            return loc;
        }
    }
}