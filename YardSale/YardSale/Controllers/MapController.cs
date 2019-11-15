using System.Web.Mvc;
using YardSale.Models;
namespace YardSale.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        [Authorize]
        public ActionResult Index()
        {
            MapModel vm = new MapModel();
            vm.Latitude = 0;
            vm.Longitude = 0;

            return View(vm);
        }
    }
}