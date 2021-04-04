using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI01.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? QtyInStock { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
    }
}