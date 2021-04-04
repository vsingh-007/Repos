using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalApps
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter sales id");
                int SalesId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter customer name");
                string CustomerName = Console.ReadLine();
                Console.WriteLine("Enter the no of units sold");
                int NoOfUnits = Convert.ToInt32(Console.ReadLine());
                if (NoOfUnits < 5)
                { throw new ArgumentOutOfRangeException("No Sales for units below 5"); }
                else
                {
                    MetalApps metalApps = new MetalApps();
                    SalesDetails salesDetails = new SalesDetails();
                    salesDetails.SalesId = SalesId;
                    salesDetails.CustomerName = CustomerName;
                    salesDetails.NoOfUnits = NoOfUnits;
                    metalApps.CalculateNetAmount(salesDetails);
                    metalApps.AddSalesDetails(salesDetails);

                    Console.WriteLine("Sales Bill \n***********");
                    Console.WriteLine("Sales Id : {0}", SalesId);
                    Console.WriteLine("Customer Name : {0}", CustomerName);
                    Console.WriteLine("Number of Units Sold : {0}", NoOfUnits);
                    Console.WriteLine("Net Amount : {0}", salesDetails.NetAmount);
                }
            }
            catch (ArgumentOutOfRangeException obj)
            {
                Console.WriteLine(obj.Message);
            }

        }
    }
}
