using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class TransfersController : Controller
    {
        public ActionResult ToMyAccounts()
        {
            return View();
        }

        public ActionResult ToOthers()
        {
            return View();
        }

        public ActionResult MyTransfers()
        {
            return View();
        }
    }
}