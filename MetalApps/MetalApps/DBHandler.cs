using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace MetalApps
{
    class DBHandler
    {
        public SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlCon"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }
}
