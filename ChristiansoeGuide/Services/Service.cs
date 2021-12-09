using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace ChristiansoeGuide.Services
{
    public class Service
    {
        //database connection stuff
        static string connStr = "server=localhost;user=root;database=ChristiansoeDatabase;port=3306;password=1;";
        //static string connStr = "server=localhost;user=root;database=ChristiansoeDatabase;port=3306;password=niko998c;";
        MySqlConnection connection = new MySqlConnection(connStr);
        
        public List<string> ferryTimesList = new List<string>();
        public List<string> tourList = new List<string>();
        public string timeToNextFerry;
        
        public void DateTime()
        {
            string stringTimeNow = System.DateTime.Now.ToString("HH:mm:ss");
            DateTime timeNow = System.DateTime.ParseExact(stringTimeNow, "HH:mm:ss", CultureInfo.InvariantCulture);

            try
            {
                connection.Open();
                string sql = "Select * From FerryTimes where FerryDateTime > " + "'" + stringTimeNow + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                
                var nextFerry = reader["FerryDateTime"].ToString();
                DateTime dateTime1 = System.DateTime.ParseExact(nextFerry, "HH:mm:ss", CultureInfo.InvariantCulture);
                timeToNextFerry = (dateTime1 - timeNow).ToString().Substring(0, 5);
            }
            
            catch (Exception e)
            {
                timeToNextFerry = (Convert.ToDateTime("23:00:00").AddHours(10) - timeNow).ToString().Substring(0, 5);
                Console.WriteLine("DB-ERROR" + e);
            }
            
            finally
            {
                connection.Close();
            }
        }

        public void FetchFerryTimes()
        {
            ferryTimesList.Clear();
            
            try
            {
                connection.Open();
                string sql = "SELECT * FROM FerryTimes";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    ferryTimesList.Add(reader["FerryDateTime"].ToString().Substring(0,5));
                }

            }
            catch (Exception e)
            {
                connection.Close();
                Console.WriteLine("DB-ERROR" + e);
            }
        }
        
        public void FetchTourList()
        {
            tourList.Clear();

            try
            {
                connection.Open();
                string sql = "SELECT * FROM Tour";
                var command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                
                reader.Read();
                tourList.Add(reader["name"].ToString());
                var xOld = (int) reader["x"];
                var yOld = (int) reader["y"];
                var xNew = 0;
                var yNew = 0;
                double distance = 0;
                while (reader.Read())
                {
                    xNew = (int) reader["x"];
                    yNew = (int) reader["y"];
                    distance += Math.Sqrt((int) Math.Pow((xOld - xNew), 2) + (int) Math.Pow((yOld - yNew), 2)) / 50;
                    xOld = xNew;
                    yOld = yNew;
                    tourList.Add(reader["name"] + " - time: " + Math.Round(distance, 0) + " min.");
                }
                command.Dispose();

            }
            catch (Exception e)
            {
                Console.WriteLine("DB-ERROR" + e);
            }
            finally
            {
                connection.Close();
            }
        }
        
        [HttpGet]
        public void AddTourToDatabase(string tmpName, int tmpX, int tmpY)
        {
            try {
                connection.Open();
                var sql = "Insert into Tour (name, x, y) VALUES (@name, @x, @y)";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                
                cmd.Parameters.AddWithValue("@name",tmpName);
                cmd.Parameters.AddWithValue("@x",tmpX);
                cmd.Parameters.AddWithValue("@y", tmpY);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("DB-ERROR" + e);
            }
            finally
            {
                connection.Close();
                // FetchTourList();
            }
        }

        public void ClearTour()
        {
            try
            {
                connection.Open();
                var sql = "DELETE FROM Tour";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("DB-ERROR" + e);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}