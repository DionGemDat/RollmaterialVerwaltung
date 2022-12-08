using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class RollingStockController : Controller
    {
        public ActionResult Overview()
        {
            ViewBag.Message = "RollingStockPage.";

            return View();
        }
    }
}