using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSample2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I can do all things...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Welcome(string name, int numtimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Numtimes = numtimes;
            return View();
        }

        ////etra
        //public ActionResult Store()
        //{
        //    ViewBag.Message = "Your Store page.";

        //    return View();
        //}

    }
}