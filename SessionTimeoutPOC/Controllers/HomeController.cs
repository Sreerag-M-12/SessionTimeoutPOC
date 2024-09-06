using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionTimeoutPOC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SetSession()
        {
            Session["UserName"] = "Sreerag"; 
            return Content("Session data set. UserName: Sreerag");
        }

        public ActionResult GetSession()
        {
            var userName = Session["UserName"];

            if (userName == null)
            {
                return Content("Session has expired or not set.");
            }

            return Content("Session data retrieved. UserName: " + userName);
        }

        public ActionResult ClearSession()
        {
            Session.Clear();  
            return Content("Session data cleared.");
        }
    }
}