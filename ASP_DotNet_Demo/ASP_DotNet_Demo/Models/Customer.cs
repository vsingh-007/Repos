using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_DotNet_Demo.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }

        [Required]
        [Display(Name= "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime ? DOB{ get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
    }
}