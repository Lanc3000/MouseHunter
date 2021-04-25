using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace MouseServer
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;database=mousedb;password=root;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();



            connection.Close();
        }
    }
}
