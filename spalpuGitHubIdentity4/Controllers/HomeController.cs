using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index(string strpage = "main")
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(strpage);
            }
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
