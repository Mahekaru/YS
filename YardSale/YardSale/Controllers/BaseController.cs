using System.Web.Mvc;
using YardSale.Models;
using YardSale.Models.CRUD;
namespace YardSale.Controllers
{
    public class BaseController : Controller
    {
        public DatabaseModel db = new DatabaseModel();
        public ProfileModel profile = new ProfileModel();

        public void SetProfile(ProfileModel Profile)
        {
            Session["Profile"] = Profile;
        }
    }
}