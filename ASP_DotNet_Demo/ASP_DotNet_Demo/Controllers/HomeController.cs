using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_DotNet_Demo.Models;

namespace ASP_DotNet_Demo.Controllers
{
    public class HomeController : Controller
    {
        readonly CustomerContext db = new CustomerContext();
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                int a= db.SaveChanges();
                if (a>0)
                {
                    return View("ViewDetails");
                }
                else
                {
                    return View("Error");
                }
            }
            else
            {
                return RedirectToAction("TestMethod");
            }
        }
        public ActionResult ViewDetails()
        {
            return View(db.Customers.ToList());
        }

        public ActionResult Edit(int id)
        {
            Customer customer = db.Customers.Find(id);
            return View("Create", customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewDetails");
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                Customer customer = db.Customers.Find(id);
                db.Customers.Remove(customer);
                db.SaveChanges();
                return RedirectToAction("ViewDetails");
            }
            return HttpNotFound();
        }
    }
}