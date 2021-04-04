using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAutomation
{
    public class ElectricityBill         //DO NOT change the class name
    {
        private string consumerNumber;
        private string consumerName;
        private int unitsConsumed;
        private double billAmount;
        public string ConsumerNumber
        {
            get
            {
                return consumerNumber;
            }
            set
            {
                if (!value.StartsWith("EB"))
                    throw new FormatException("Invalid Consumer Number");
                consumerNumber = value;
            }
        }
        public string ConsumerName { get; set; }
        public int UnitsConsumed { get; set; }
        public double BillAmount { get; set; }
    }
}
