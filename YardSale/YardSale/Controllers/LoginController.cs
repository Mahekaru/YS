using System.Collections.Generic;
using System.Linq;
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
            LoginModel vm = new LoginModel();
            vm.HasError = false;
            return View(vm);
        }

        private YSDatabaseEntities db = new YSDatabaseEntities();
        [HttpPost]
        public ActionResult Login(LoginModel vm)
        {
            List<User> t = new List<User>();
            User usr = new User();
            usr.Username = vm.Username;
            usr.Password = vm.Password;

            t = db.Users.ToList();
            
            if (!t.Contains(usr))
            {
                vm.HasError = true;
                vm.ErrorMessage = "Username or Password is Incorrect, Please Try Again";
                return View("Index",vm);
            }
            return RedirectToAction("Index", "Map", "");
        }
    }
}