using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class MemberAdministrationController : Controller
    {

        public ActionResult Overview()
        {
            ViewBag.Message = "MemberAdministrationPage.";

            return View();
        }
    }
}