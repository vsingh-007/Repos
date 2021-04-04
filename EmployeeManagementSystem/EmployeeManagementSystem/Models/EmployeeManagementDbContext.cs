using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models
{
    public class EmployeeManagementDbContext:DbContext
    {
        public EmployeeManagementDbContext():base("EmployeeConnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}