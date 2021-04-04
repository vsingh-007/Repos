using CarPool1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarPool1.Controllers
{
    public class CarPoolController : Controller
    {
        // GET: CarPool
        readonly List<SelectListItem> From = new List<SelectListItem>()
                     {
                        new SelectListItem { Text = "A1", Value = "A1" },
                        new SelectListItem { Text = "B1", Value = "B1" }
                     };
        readonly List<SelectListItem> To = new List<SelectListItem>()
                     {
                        new SelectListItem { Text = "D1", Value = "D1" },
                        new SelectListItem { Text = "E1", Value = "E1" }
                     };

        static List<Ride> new_rt;

        readonly List<Ride> rt = new List<Ride>() {
            new Ride{CarNo="TNCF3456",NoofSeats=3,From="A1",To="D1",PhoneNumber="9910234434"},
            new Ride{CarNo="TNCF9813",NoofSeats=2,From="A1",To="D1",PhoneNumber="8763234567"},
            new Ride{CarNo="TNCF5567",NoofSeats=4,From="A1",To="E1",PhoneNumber="7810234434"},
            new Ride{CarNo="TNCF9987",NoofSeats=2,From="B1",To="D1",PhoneNumber="8944211233"},
            new Ride{CarNo="TNCF4534",NoofSeats=3,From="B1",To="E1",PhoneNumber="7677885546"},
            };

        public ActionResult Carpool()
        {

            return View();
        }
        public ActionResult FindRide()
        {
            ViewBag.From = From;
            ViewBag.To = To;
            return View();
        }

        [HttpPost]
        public ActionResult FindRide(Ride fd)
        {



            new_rt = new List<Ride>();
            for (int cnt = 0; cnt < rt.Count; cnt++)
            {
                if (rt.ElementAt(cnt).From.Equals(fd.From) && rt.ElementAt(cnt).To.Equals(fd.To))
                {
                    Console.WriteLine("From " + rt.ElementAt(cnt).From + "From" + fd.From);
                    Console.WriteLine("To " + rt.ElementAt(cnt).To + "To" + fd.To);
                    new_rt.Add(rt.ElementAt(cnt));

                }
            }
            ViewBag.RideList = new_rt;

            return View("VehicleList");

        }

        [HttpGet]
        [Route("Carpool/ConfirmRide/{carNo}")]
        public ActionResult ConfirmRide(String carNo)
        {
            ViewBag.RideList = new_rt;
            ViewBag.message = "Your Offer has been confirmed. Car Registration No : " + carNo;

            return View("VehicleList");

        }

    }
}