using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPWebApplication.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult first()
        {
            return View();
        }

        public ActionResult Second()
        {
            return View();
        }
        public ActionResult third()
        {
            return View();
        }
    }
}