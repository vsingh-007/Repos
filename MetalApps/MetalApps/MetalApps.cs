using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalApps
{
    class MetalApps
    {
        public SqlConnection SqlCon;
        public void AddSalesDetails(SalesDetails sd)
        {
            DBHandler dBHandler = new DBHandler();
            SqlCon = dBHandler.GetConnection();
            SqlCommand sqlCommand = new SqlCommand("Insert into SalesDetails values(@Sales_id, @Customer_name , @No_of_units, @Net_amount)", SqlCon);
            sqlCommand.Parameters.AddWithValue("@Sales_id", sd.SalesId);
            sqlCommand.Parameters.AddWithValue("@Customer_name", sd.CustomerName);
            sqlCommand.Parameters.AddWithValue("@No_of_units", sd.NoOfUnits);
            sqlCommand.Parameters.AddWithValue("@Net_amount", sd.NetAmount);

            SqlCon.Open();
            sqlCommand.ExecuteNonQuery();
            SqlCon.Close();
            sqlCommand.Dispose();
            SqlCon.Dispose();
        }

        public void CalculateNetAmount(SalesDetails details)
        {
            float discount = 0;
            double wholeSaleRate = 75350;
            double NetAmount = 0;
            if (details.NoOfUnits <= 5)
            {
                discount = 0;
            }
            else if (details.NoOfUnits > 5 && details.NoOfUnits <= 10)
            {
                discount = 0.02f;
            }
            else if (details.NoOfUnits > 10 && details.NoOfUnits <= 15)
            {
                discount = 0.05f;
            }
            else if (details.NoOfUnits > 15 && details.NoOfUnits <= 20)
            {
                discount = 0.08f;
            }
            else
            {
                discount = 0.10f;
            }
            details.NetAmount = Math.Round((details.NoOfUnits * wholeSaleRate) - ((details.NoOfUnits * wholeSaleRate) * discount));
        }
    }
}
