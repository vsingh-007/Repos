using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BillAutomation
{
    public class DBHandler    //DO NOT change the class name
    {
        //Implement the methods as per the description
        public SqlConnection GetConnection()
        {
        string MyCon = ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
        return new SqlConnection(MyCon);
        }
    }
}
