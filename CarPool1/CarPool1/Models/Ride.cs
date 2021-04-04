using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarPool1.Models
{
    public class Ride
    {
        public String From { get; set; }
        public String To { get; set; }
        public String CarNo { get; set; }
        public int NoofSeats { get; set; }
        public String Date { get; set; }
        public String PhoneNumber { get; set; }

    }
}