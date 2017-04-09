using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO
{
    
    class Program
    {
        public static void CreateCommand(string queryString,    string connectionString)
        {
    //        SqlConnection conn = new SqlConnection("server=(local);" +
    //"Integrated Security=SSPI;database=BookShop");
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}", reader[0]));
                }
                reader.Close();
                
            }
        }
        static void Main(string[] args)
        {
            CreateCommand("SELECT * FROM BooksShop ", "Data Source=.\\SQLEXPRESS;Initial Catalog=BooksShop;Integrated Security=True"
            );
        }
    }
}
