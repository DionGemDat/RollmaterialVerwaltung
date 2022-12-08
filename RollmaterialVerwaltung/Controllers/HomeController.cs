using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reservation()
        {
            ViewBag.Message = "ReservationPage.";

            return View();
        }

        public ActionResult RollingStock()
        {
            ViewBag.Message = "RollingStockPage.";

            return View();
        }

        public ActionResult TrainComposition()
        {
            ViewBag.Message = "TrainCompositionPage.";

            return View();
        }

        public ActionResult MemberAdministration()
        {
            ViewBag.Message = "MemberAdministrationPage.";

            return View();
        }
    }
}