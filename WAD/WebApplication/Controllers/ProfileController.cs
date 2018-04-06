using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult MyAccounts()
        {
            return View();
        }

        public ActionResult NewAccount()
        {
            return View();
        }

        public ActionResult Accounts()
        {
            return View();
        }
    }
}