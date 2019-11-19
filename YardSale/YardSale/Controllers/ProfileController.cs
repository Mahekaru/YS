using System.Net;
using System.Web.Mvc;
using YardSale.Models;

namespace YardSale.Controllers
{
    public class ProfileController : BaseController
    {
 
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