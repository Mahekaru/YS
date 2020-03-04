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
            //return "";
            YSDatabaseEntities1 db = new YSDatabaseEntities1();
            return "";
        }

        public string GetGeoCodeKey()
        {
            //return "";
            YSDatabaseEntities1 db = new YSDatabaseEntities1();
            return "";
        }

        public Location GetGeoCode()
        {
            Location loc = new Location(0,0);
            return loc;
        }
    }
}