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
        private string connectionString = "server=localhost;user=root;database=mousedb;password=root;";
        
        public bool Authorization(string log, string pas)
        {
            string sql = $"SELECT password FROM users_tab WHERE login LIKE '{log}'";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("Установлено соединение с БД");
                MySqlCommand command = new MySqlCommand(sql, conn);
                string check = command.ExecuteScalar().ToString();
                if (check == pas)
                {
                    Console.WriteLine("Аутентификация прошла успешно!");
                    
                    return true;
                }
            }
            return false;
        }

        public void Insert(DateTime date, string ev, string coord)
        {
            Console.WriteLine("Идет запись в БД");
            string sqlMsq = "Insert into events_tab (date, event, coordinates) values(@date, @event, @coordinates)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand comd = new MySqlCommand(sqlMsq, conn);
                comd.Parameters.AddWithValue("@date", date);
                comd.Parameters.AddWithValue("@event", ev);
                comd.Parameters.AddWithValue("@coordinates", coord);

                int num = comd.ExecuteNonQuery();
                Console.WriteLine($"Добавлено объектов: {num}");
            }
        }
    }
}
