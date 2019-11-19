﻿using System.Web.Mvc;
using YardSale.Models;
using YardSale.Models.CRUD;
namespace YardSale.Controllers
{
    public class LoginController : Controller
    {
        DatabaseModel db = new DatabaseModel();
        // GET: Login
        public ActionResult Index()
        {
            LoginModel vm = new LoginModel();
            vm.HasError = false;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Login(LoginModel vm)
        {
           
            User usr = new User();
            usr.Username = vm.Username;
            usr.Password = vm.Password;

            if (!db.Login(usr))
            {
                vm.HasError = true;
                vm.ErrorMessage = "Username or Password is Incorrect, Please Try Again";
                return View("Index",vm);
            }

            AuthorizationContext()
            return RedirectToAction("Index", "Map", "");
        }
    }
}