
namespace PoolMonitoringWebRole.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Pool Monitoring application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Marc Nazarian";

            return View();
        }
    }
}