using System.Web.Mvc;
using YardSale.Models;
using YardSale.Models.CRUD;

namespace YardSale.Controllers
{
    public class ProfileController : Controller
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

        private YSDatabaseEntities db = new YSDatabaseEntities();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfileModel vm)
        {

            User newUser = new User();
            //newUser = db.Users.Find(vm.UserName);

            if (newUser == null)
            {
                return HttpNotFound();
            }
            else
            {
                newUser.UserName = vm.UserName;
                newUser.Password = vm.Password;
                newUser.Email = vm.Email;
                newUser.Address = vm.Address;
                newUser.City = vm.City;
                newUser.State = vm.State;
                newUser.Phone = vm.Phone;

                db.Users.Add(newUser);
                db.SaveChanges();
            }

            return RedirectToAction("Index","Login","");
        }
    }
}