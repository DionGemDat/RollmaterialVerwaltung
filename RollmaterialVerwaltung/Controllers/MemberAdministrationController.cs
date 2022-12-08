using System.Web.Mvc;

namespace RollmaterialVerwaltung.Controllers
{
    public class MemberAdministrationController : Controller
    {

        public ActionResult MemberAdministration()
        {
            ViewBag.Message = "MemberAdministrationPage.";

            return View();
        }
    }
}