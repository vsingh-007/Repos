using Glimpse.AspNet.Tab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<String> breakingNews = new List<String>()      //DO NOT change this declaration and values
        {
            "PM visit brings business","10% slash in GST","Top Player announced retirement","India wins series"
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult First()
        {
            return View();
        }

        public ActionResult Second()    
        {
            return View();
        }
        public ActionResult Third()
        {
            return View();
        }

        //[HttpGet]
        //[Route("Home/NewsByChoice/{choice}")]
        
        public ActionResult NewsByChoice(int id)
        {
            return Content(breakingNews[id-1]);
        }

        // Implement 'AllNews' action
        
        public ActionResult AllNews()
        {
            string news = "";
            foreach (var i in breakingNews)
            {
                news += i + "<br>";
            }
            return Content(news);
        }

        public ActionResult AddNumbers_PassData_UsingFormsCollection()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddNumbers_PassData_UsingFormsCollection(FormCollection formCollection)
        {
            int x = Convert.ToInt16(formCollection["txtNo1"]);
            int y = Convert.ToInt16(formCollection["txtNo2"]);
            ViewBag.result = x + y;
            return View();

        }

    }
}