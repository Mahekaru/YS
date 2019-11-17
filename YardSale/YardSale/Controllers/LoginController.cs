using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YardSale.Models;
using YardSale.Models.CRUD;
namespace YardSale.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        private YSDatabaseEntities db = new YSDatabaseEntities();
        [HttpPost]
        public ActionResult Login(ProfileModel vm)
        {
            List<User> t = new List<User>();
            User usr = new User();
            usr.UserName = vm.UserName;
            usr.Password = vm.Password;

            t = db.Users.ToList();
            
            if (!t.Contains(usr))
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index", "Map", "");
        }
    }
}