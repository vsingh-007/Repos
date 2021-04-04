using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillAutomation
{
    public class ElectricityBoard  //DO NOT change the class name
    {
        //Implement the property as per the description
        public SqlConnection SqlCon { get; set; }

        //Implement the methods as per the description 
        public void AddBill(ElectricityBill ebill)
        {
            DBHandler dBHandler = new DBHandler();
            SqlCon = dBHandler.GetConnection();
            SqlCommand cmd = new SqlCommand("insert into ElectricityBill values(@consumer_number,@consumer_name,@units_consumed,@bill_amount)", SqlCon);
            cmd.Parameters.AddWithValue("@consumer_number", ebill.ConsumerNumber);
            cmd.Parameters.AddWithValue("@consumer_name", ebill.ConsumerName);
            cmd.Parameters.AddWithValue("@units_consumed", ebill.UnitsConsumed);
            cmd.Parameters.AddWithValue("@bill_amount", ebill.BillAmount);
            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();
        }

        public void CalculateBill(ElectricityBill ebill)
        {
            int unitsConsumed = ebill.UnitsConsumed;
            double total = 0;
            if (unitsConsumed > 1000)
            {
                total += ((unitsConsumed - 1000) * 7.5);
                unitsConsumed = 1000;
            }
            if (unitsConsumed > 600 && unitsConsumed <= 1000)
            {
                total += ((unitsConsumed - 600) * 5.5);
                unitsConsumed = 600;
            }
            if (unitsConsumed > 300 && unitsConsumed <= 600)
            {
                total += ((unitsConsumed - 300) * 3.5);
                unitsConsumed = 300;
            }
            if (unitsConsumed > 100 && unitsConsumed <= 300)
            {
                total += ((unitsConsumed - 100) * 1.5);
            }
            ebill.BillAmount = total;
        }

        public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> ebills = new List<ElectricityBill>();
            DBHandler dBHandler = new DBHandler();
            SqlCon = dBHandler.GetConnection();
            SqlCon.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM (SELECT TOP " + num + " * FROM ElectricityBill ORDER BY consumer_number DESC)c ORDER BY consumer_number", SqlCon);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ElectricityBill electricityBill = new ElectricityBill();
                    electricityBill.ConsumerNumber = reader["consumer_number"].ToString();
                    electricityBill.ConsumerName = reader["consumer_name"].ToString();
                    electricityBill.UnitsConsumed = (int)reader["units_consumed"];
                    electricityBill.BillAmount = (double)reader["bill_amount"];
                    ebills.Add(electricityBill);
                }
            }
            SqlCon.Close();
            return ebills;
        }
    }
}
