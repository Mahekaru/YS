using System.Web.Mvc;
using YardSale.Models.CRUD;

namespace YardSale.Controllers
{
    public class MapController : BaseController
    {

        public ActionResult Index(User Usr)
        {
            GetProfile();
            profile.Map.Address = string.Format("{0} {1} {2} {3} {4}", profile.Address1 , profile.Address2 , profile.City , profile.State , profile.Zipcode);
            profile.Map.Longitude = 0;
            profile.Map.Latitude = 0;

            return View(profile);
        }
    }
}