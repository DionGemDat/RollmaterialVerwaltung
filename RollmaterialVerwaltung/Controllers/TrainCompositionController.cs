using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class TrainCompositionController : Controller
    {
        public ActionResult Overview()
        {
            ViewBag.Message = "TrainCompositionPage.";

            return View();
        }
    }
}