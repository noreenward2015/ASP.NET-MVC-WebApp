using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello Marta!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I'm customising the code...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "...to make it look prettier";

            return View();
        }
    }
}
