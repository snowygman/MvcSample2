using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSample2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Titty = "Store Front";
            return View();
        }



        // GET: /Store/
        //public string Index()
        //{
        //    return "Hello from Store.Index()";
        //}

        // GET: /Store/Browse?genre=drama
        public string Browse(string genre)
        {
            return //"Hello from Store.Browse()";
                    HttpUtility.HtmlEncode("Browse > Genre > " + genre);
        }
        //
        // GET: /Store/Details/5
        public string Details(int id)
        {
            //return "Hello from Store.Details()";
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}