using ExpenseManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Models        //DO NOT change the namespace name
{
    class ExpenseContext : DbContext     //DO NOT change the class name
    {
      
        public ExpenseContext() : base("EMS_DB")   //DO NOT change the connection string name
        {
        }
         public DbSet<Expense> Expenses { get; set; }
		//Declare property 'Expenses' of type DbSet<Expense>. 
    }
}


	 	  	 	 	   	  	    	 	
