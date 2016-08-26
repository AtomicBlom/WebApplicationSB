using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationSB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            for (var i = 0; i < 500; ++i )
            {
                var test = "1";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}