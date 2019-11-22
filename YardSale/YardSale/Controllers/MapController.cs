using GoogleMapsApi;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Geocoding.Request;
using System.Linq;
using System.Web.Mvc;
using YardSale.Models;
namespace YardSale.Controllers
{
    public class MapController : BaseController
    {

        public ActionResult Index()
        {
            MapModel map = new MapModel();

            profile = (ProfileModel)Session["Profile"];
            map.Address = "";
            //map.Address = string.Format("{0} {1} {2} {3} {4}", profile.Address1 , profile.Address2 , profile.City , profile.State , profile.Zipcode);
            map.Longitude = 0;
            map.Latitude = 0;

            return View(map);
        }

        [HttpPost]
        public ActionResult Search(MapModel vm)
        {
            GeocodingRequest GeoRequest = new GeocodingRequest();
            Location GeoCode;

            profile = (ProfileModel)Session["Profile"];
            profile.Map = vm;

            GeoRequest.ApiKey = "";
            GeoRequest.Address = vm.Address;

            GeoCode = GoogleMaps.Geocode.QueryAsync(GeoRequest).Result.Results.Select(x => x.Geometry.Location).FirstOrDefault();

            vm.Latitude = GeoCode.Latitude;
            vm.Longitude = GeoCode.Longitude;

            return View("Index",vm);
        }
    }
}