﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_DotNet_Demo.Models
{
    public class CustomerContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}