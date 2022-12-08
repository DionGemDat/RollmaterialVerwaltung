using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class TrainCompositionController : Controller
    {
        public ActionResult TrainComposition()
        {
            ViewBag.Message = "TrainCompositionPage.";

            return View();
        }
    }
}