using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Models      //DO NOT change the namespace name
{
   public class Expense    //DO NOT change the class name
    {
	 [Key]
        public int ExpenseId { get; set; }

        [Required(ErrorMessage = "Please Provide Valid Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime DateOfExpense { get; set; }

        [Required(ErrorMessage = "Please Select An Expense Type")]
        public string ExpenseType { get; set; }

       // public IEnumerable<SelectListItem> Expensetype { get; set; }
        [Required(ErrorMessage = "Please Provide Expense Amount")]
        public int Amount { get; set; }
	//Declare Properties with respective annotations required for validation	 
    }
}
