using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class HomeController : Controller
    {
        RentalContext db = new RentalContext();
        // GET: Home
        public ActionResult Index()
        {
            //var list = db.VehicleTypes.ToList();
            return View();
        }

        public ActionResult Insert()
        {
            VehicleType vehicle = new VehicleType();
            return View(vehicle);
        
        }
       [HttpPost] public ActionResult Insert(VehicleType vehicle)
        {
            if (ModelState.IsValid)
            {
                db.VehicleTypes.Add(vehicle);
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        public ActionResult RentList()
        {
            var list = db.Rents.ToList();
            return View(list);
        }

        public ActionResult RentInsert()
        {
            Rent rent = new Rent();
            ViewBag.Data = db.VehicleTypes.ToList();
            return View(rent);

        }
        [HttpPost]
        public ActionResult RentInsert(Rent rent)
        {
            if (ModelState.IsValid)
            {
                db.Rents.Add(rent);
                db.SaveChanges();
            }
            else {
                return View("RentInsert");
            
            }
            return RedirectToAction("RentList");

        }
    
}
}