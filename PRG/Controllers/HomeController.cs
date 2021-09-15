using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRG.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Services()
        {
            ViewBag.Message = "Your services page.";

            return View();
        }

        [Authorize]
        public ActionResult Portfolio()
        {  
           return View();  
        }
        public ActionResult fail()
        {
            ViewBag.Message = "Your fail page.";

            return View();
        }


    }
}