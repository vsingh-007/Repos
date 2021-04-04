//THIS CLASS IS FOR YOUR REFRENCE. YOU NEED NOT CHANGE HERE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseManagement.Models
{
    public class ExpenseViewModel
    {

        public Expense Expense { get; set; }


        public IEnumerable<SelectListItem> ExpenseTypeList
        {
            get
            {
                return new List<SelectListItem>()
                     {
                       new SelectListItem { Text = "Food Expense", Value = "Food Expense" },
                        new SelectListItem { Text = "Health Expense", Value = "Health Expense" },
                        new SelectListItem { Text = "Travel Expense", Value = "Travel Expense" },
                        new SelectListItem { Text = "Entertainment Expense", Value = "Entertainment Expense" },
                     };
            }
            set
            {

            }

        }
    }
}