using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace WcfMouceService
{

    public class Service1 : IService1
    {
        private string connectionString = "server=localhost;user=root;database=mousedb;password=root;";
        DataTable eventsTable;
        
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

        public GetEventData GetInfo()
        {
            GetEventData eventData = new GetEventData();
            string sqlMsg = "SELECT * FROM events_tab";
            eventsTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlMsg, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                eventData.EventTable = dataTable;
                eventData.EventTable.TableName = "events_tab";
                return eventData;
            }
        }



        public void Insert(MouseEv mouse)
        {
            Console.WriteLine("Идет запись в БД");
            string sqlMsg = "INSERT INTO events_tab (date, event, coordinates) VAlUES (@date, @event, @coordinates)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand comd = new MySqlCommand(sqlMsg, conn);
                comd.Parameters.AddWithValue("@date", mouse.Date);
                comd.Parameters.AddWithValue("@event", mouse.MouseEvent);
                comd.Parameters.AddWithValue("@coordinates", mouse.Coordinate);

                int num = comd.ExecuteNonQuery();
                Console.WriteLine($"Добавлено объектов: {num}");
            }
        }

        public DataTable LoadFromDB()
        {
            string sqlMsg = "SELECT * FROM events_tab";
            eventsTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(sqlMsg, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.InsertCommand = new MySqlCommand("sp_InsertEvents", conn);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("@date", MySqlDbType.DateTime, 0, "date"));
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("@event", MySqlDbType.VarChar, 100, "event"));
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("@coordinates", MySqlDbType.VarChar, 100, "coordinates"));
                MySqlParameter parametr = adapter.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "Id");
                parametr.Direction = ParameterDirection.Output;

                conn.Open();
                adapter.Fill(eventsTable);
                eventsTable.TableName = "events_tab";
                return eventsTable;
            }
        }
    }
}
