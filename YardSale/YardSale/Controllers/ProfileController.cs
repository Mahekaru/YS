using System.Net;
using System.Web.Mvc;
using YardSale.Models;
using YardSale.Models.CRUD;

namespace YardSale.Controllers
{
    public class ProfileController : Controller
    {
        DatabaseModel db = new DatabaseModel();
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfileModel vm)
        {
            if(!db.CreateNewUser(vm))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return RedirectToAction("Index","Login","");
        }
    }
}