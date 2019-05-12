using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication56.Controllers
{
    public class Employe
    {
        public int Id { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {// check
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