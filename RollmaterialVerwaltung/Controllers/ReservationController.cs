using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class ReservationController : Controller
    {
        public ActionResult Reservation()
        {
            ViewBag.Message = "ReservationPage.";

            return View();
        }
    }
}