using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;

namespace WcfMouceService
{
    public class Service1 : IService1
    {
        string connectionString = "server=localhost;user=root;database=mousedb;password=root;";
        public bool Authorization(string log, string pas)
        {
            string sql = $"SELECT password FROM users_tab WHERE login LIKE '{log}'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(sql, conn);
                string check = command.ExecuteScalar().ToString();
                if (check == pas)
                    return true;
            }
            return false;
        }

        
    }
}
