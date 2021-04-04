using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    class Program
    {
        static void Main()
        {
            SqlConnection connection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=useme;Trusted_Connection=True;");
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Conection Established...");
            }
            string text = "select * from Employee";
            SqlCommand command = new SqlCommand(text, connection);
            connection.Open();
            //command.ExecuteNonQuery();
            //Console.WriteLine("Data Inserted...");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + " " + reader[1]);
            }
            reader.Close();
            connection.Close();
            command.Dispose();
            connection.Dispose();
            Console.WriteLine("Connection Closed.");

        }
    }
}
