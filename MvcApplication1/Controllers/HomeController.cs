using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
<<<<<<< HEAD
            ViewBag.Message = "My awesome ASP.NET MVC application with changes 032701.";
=======
            ViewBag.Message = "My awesome ASP.NET MVC application with changes 0324.";
>>>>>>> 21ca543b97803c641a24a0bec1d1c8738980a61f

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
