﻿using System;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChristiansoeGuide.Models;
using MySql.Data.MySqlClient;

namespace ChristiansoeGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //database connection stuff
        static string connStr = "server=localhost;user=root;database=ChristiansoeDatabase;port=3306;password=Mysqlroot;";
        //static string connStr = "server=localhost;user=root;database=ChristiansoeDatabase;port=3306;password=niko998c;"; 
        MySqlConnection connection = new MySqlConnection(connStr);
        private List<string> ferryTimesList = new List<string>();
        private List<string> tourList = new List<string>();
        private string timeToNextFerry;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            DateTimeTest();
            FetchFerryTimes();

            ViewBag.Message = timeToNextFerry;
            return View(ferryTimesList);
        }

        private void FetchFerryTimes()
        {
            if (ferryTimesList.Count > 0)
            {
                ferryTimesList.Clear();
            }
            
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
        
        private void FetchTourList()
        {
            if (tourList.Count > 0)
            {
                tourList.Clear();
            }

            try
            {
                connection.Open();
                string sql = "SELECT * FROM Tour";
                MySqlCommand command = new MySqlCommand(sql, connection);
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

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult TourMaker()
        {
            FetchTourList();
            return View(tourList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public void DateTimeTest()
        {
            string timeNow = DateTime.Now.ToString("HH:mm:ss");
            DateTime dateTime2 = DateTime.ParseExact(timeNow, "HH:mm:ss", CultureInfo.InvariantCulture);

            try
            {
                connection.Open();
                string sql = "Select * From FerryTimes where FerryDateTime > " + "'" + timeNow + "'";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                
                var nextFerry = reader["FerryDateTime"].ToString();
                DateTime dateTime1 = DateTime.ParseExact(nextFerry, "HH:mm:ss", CultureInfo.InvariantCulture);
                timeToNextFerry = (dateTime1 - dateTime2).ToString().Substring(0, 5);
            }
            
            catch (Exception e)
            {
                timeToNextFerry = (Convert.ToDateTime("23:00:00").AddHours(10) - dateTime2).ToString().Substring(0, 5);
                Console.WriteLine("DB-ERROR" + e);
            }
            
            finally
            {
                connection.Close();
            }
        }
    }
}