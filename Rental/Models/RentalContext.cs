using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class RentalContext:DbContext
    {
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Rent> Rents { get; set; }

    }
}