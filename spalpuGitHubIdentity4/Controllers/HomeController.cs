using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult ForgotPasswordConfirmationTest()
        {
            return View();
        }
        public ActionResult DisplayEmailTest()
        {
            return View();
        }
        public ActionResult ConfirmEmailTest()
        {
            return View();
        }
        public ActionResult ForgotPasswordTest()
        {
            return View();
        }
        public ActionResult RegisterTest()
        {
            return View();
        }
        public ActionResult LoginTest()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
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
            return View();
        }
        public ActionResult Video()
        {
            return View();
        }

    }
}
