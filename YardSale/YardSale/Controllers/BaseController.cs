using System.Web.Mvc;
using YardSale.Models;
using YardSale.Models.CRUD;
namespace YardSale.Controllers
{
    public class BaseController : Controller
    {
        public DatabaseModel db = new DatabaseModel();
        public ProfileModel profile;

        public void SetProfile(ProfileModel Profile)
        {
            Session["Profile"] = Profile;
        }

        public void GetProfile()
        {
            profile = (ProfileModel)Session["Profile"];
            Session.Timeout = 60;
        }
    }
}