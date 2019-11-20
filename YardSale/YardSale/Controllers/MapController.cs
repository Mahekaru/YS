using System.Web.Mvc;
using YardSale.Models.CRUD;
using YardSale.Models;
namespace YardSale.Controllers
{
    public class MapController : BaseController
    {

        public ActionResult Index()
        {
            MapModel map = new MapModel();

            profile = (ProfileModel)Session["Profile"];

            map.Address = string.Format("{0} {1} {2} {3} {4}", profile.Address1 , profile.Address2 , profile.City , profile.State , profile.Zipcode);
            map.Longitude = 0;
            map.Latitude = 0;

            return View(map);
        }

        [HttpPost]
        public ActionResult Search(MapModel vm)
        {
            profile = (ProfileModel)Session["Profile"];
            profile.Map = vm;
            
            return View("Index",vm);
        }
    }
}