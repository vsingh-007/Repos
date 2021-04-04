using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagementSystem.Models;
namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public EmployeeManagementDbContext context = new EmployeeManagementDbContext();
        public ActionResult Index()
        {
            List<Employee> employee = context.Employees.ToList();
            return View(employee);
        }

        [HttpGet]
        public ActionResult Details(int? Id)
        {
            
            if (Id != null)
            {
                Employee emp = context.Employees.Find(Id);
                return View(emp);
            }
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index","Employee");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(string Id)
        {

            if(Id!=null)
            {
                int ID = (int)Id.Substring(4);
                Employee emp = context.Employees.Find(ID);
                return View(emp);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            if(ModelState.IsValid)
            {
                context.Entry(employee).State = EntityState.Deleted;
                context.SaveChanges();
                return View("Index");
                //return RedirectToAction("Index", "Employee");
            }
            return View(employee);
        }
    }
}