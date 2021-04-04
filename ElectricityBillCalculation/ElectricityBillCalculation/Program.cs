using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement the code here
            List<ElectricityBill> eBills = new List<ElectricityBill>();
            ElectricityBoard board = new ElectricityBoard();
            Console.WriteLine("Enter Number of Bills To Be Added:");
            int numOfBills = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfBills; i++)
            {
                ElectricityBill bill = new ElectricityBill();
                Console.WriteLine("Enter Consumer Number:");
                bill.ConsumerNumber = Console.ReadLine();
                Console.WriteLine("Enter Consumer Name:");
                bill.ConsumerName = Console.ReadLine();
                Console.WriteLine("Enter Units Consumed:");
                int units = int.Parse(Console.ReadLine());
                BillValidator billValidator = new BillValidator();
                string isValid = billValidator.ValidateUnitsConsumed(units);
                while (isValid != "valid")
                {
                    Console.WriteLine(isValid);
                    Console.WriteLine("Enter Units Consumed:");
                    units = int.Parse(Console.ReadLine());
                    isValid = billValidator.ValidateUnitsConsumed(units);
                }
                bill.UnitsConsumed = units;
                board.CalculateBill(bill);
                eBills.Add(bill);
                board.AddBill(bill);
            }
            Console.WriteLine("Enter Last 'N' Number of Bills To Generate:");
            int lastNBillsToGenerate = int.Parse(Console.ReadLine());
            List<ElectricityBill> generatedBills = board.Generate_N_BillDetails(lastNBillsToGenerate);
            foreach (ElectricityBill bill in eBills)
            {
                Console.WriteLine(bill.ConsumerNumber);
                Console.WriteLine(bill.ConsumerName);
                Console.WriteLine(bill.UnitsConsumed);
                Console.WriteLine("Bill Amount: " + bill.BillAmount);
            }
            Console.WriteLine("Detials of last 'N' bills");
            foreach (ElectricityBill gbill in generatedBills)
            {
                Console.WriteLine("EB Bill for " + gbill.ConsumerName + " is " + gbill.BillAmount);
            }
        }

        public class BillValidator
        {      //DO NOT change the class name

            public String ValidateUnitsConsumed(int UnitsConsumed)      //DO NOT change the method signature
            {
                //Implement code here
                if (UnitsConsumed < 0)
                    return "Given units is invalid";
                return "valid";
            }
        }
    }
}
