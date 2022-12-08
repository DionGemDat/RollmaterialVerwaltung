using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class ReservationController : Controller
    {
        public ActionResult Overview()
        {
            ViewBag.Message = "ReservationPage.";

            return View();
        }
    }
}