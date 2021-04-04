using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalApps
{
    class SalesDetails
    {
        private int salesId;
        private string customerName;
        private int noOfUnits;
        private double netAmount;

        public int SalesId { get; set; }
        public string CustomerName { get; set; }
        public int NoOfUnits { get; set; }
        public double NetAmount { get { return netAmount; } set {this.netAmount=value; } }

    }
}
