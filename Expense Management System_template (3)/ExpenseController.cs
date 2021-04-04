using ExpenseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseManagement.Controllers            //DO NOT change the namespace name
{
    public class ExpenseController : Controller    //DO NOT change the class name   
    {
		
        public ActionResult Index()         //DO NOT change the action name
        {
            //fill code here
             var context = new ExpenseContext();
            List<Expense> expense = context.Expenses.ToList();
            return View(expense);
        }

        public ActionResult AddExpense()   //DO NOT change the action name
        {
            var viewModel = new ExpenseViewModel();
            //fill code here
                        ViewBag.ExpenseTypes = viewModel.ExpenseTypeList;
            return View(viewModel);
        }
	 	  	 	 	   	  	    	 	
        [HttpPost]
	public ActionResult AddExpense(Expense Expense)    //DO NOT change the action name
        {
            var viewModel = new ExpenseViewModel();
            ViewBag.ExpenseTypes = viewModel.ExpenseTypeList;
            //fill code here
             if (ModelState.IsValid)
            {
                var context = new ExpenseContext();
                context.Expenses.Add(Expense);
                context.SaveChanges();

             //   return RedirectToAction("Index");
              return View(viewModel);
             }
            ViewBag.Flag=1;
            return View(viewModel);
        }
    }
}