using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class VehicleType
    {
        [Key]
        [Required]
        public int VehicleTypeId { get; set; }

        
        [Required]
        public string vehicleType { get; set; }
    }
}