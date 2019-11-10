using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mostachio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Galery()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
