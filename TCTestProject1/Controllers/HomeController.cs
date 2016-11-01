using System.Web.Mvc;

namespace TCTestProject1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "TCTestProjct Main Page";

            return View();
        }
    }
}
