using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace spalpuGitHubIdentity4.Controllers
{
    [OutputCache(Duration = 604800)]
    public class spaController : Controller
    {
        public ActionResult spa()
        {
            return View();
        }
        public ActionResult aussage()
        {
            return View();
        }
        public ActionResult globalIssues()
        {
            return View();
        }
        public ActionResult more_about_health()
        {
            return View();
        }
        public ActionResult spastic_muscle_condition()
        {
            return View();
        }
        public ActionResult balanced_diet()
        {
            return View();
        }
        public ActionResult physical_activity()
        {
            return View();
        }
        public ActionResult health_education()
        {
            return View();
        }
        public ActionResult biomechanics()
        {
            return View();
        }
        public ActionResult commonplace_truths()
        {
            return View();
        }
        public ActionResult effects_of_injury()
        {
            return View();
        }
        public ActionResult trial_error_method()
        {
            return View();
        }
        public ActionResult psychological_attitudes()
        {
            return View();
        }
        public ActionResult physical_activities()
        {
            return View();
        }
        public ActionResult relaxation()
        {
            return View();
        }
        public ActionResult stress_relaxation()
        {
            return View();
        }
    }
}