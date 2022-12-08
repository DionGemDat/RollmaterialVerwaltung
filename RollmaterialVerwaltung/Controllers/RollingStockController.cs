using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class RollingStockController : Controller
    {
        public ActionResult RollingStock()
        {
            ViewBag.Message = "RollingStockPage.";

            return View();
        }
    }
}