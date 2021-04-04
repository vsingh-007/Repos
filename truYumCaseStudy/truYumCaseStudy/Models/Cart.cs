using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace truYumCaseStudy.Models
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        public MenuItem MenuItems { get; set; }

    }
}