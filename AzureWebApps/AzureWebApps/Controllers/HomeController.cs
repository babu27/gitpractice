using System.Web.Mvc;

namespace AzureWebApps.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.Babu when to start git";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.About change..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
