using System;
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
        static String connStr = "server=localhost;user=root;database=ChristiansoeDatabase;port=3306;password=Mysqlroot;";
        MySqlConnection connection = new MySqlConnection(connStr);
        private List<string> ferryTimesList = new List<string>();

        private ArrayList test = new ArrayList();
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            FetchData();
            return View(ferryTimesList);
        }

        private void FetchData()
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
                    ferryTimesList.Add(reader["FerryDateTime"].ToString());
                }
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("DB-ERROR" + e);
            }
        }
        
        [HttpGet]
        public void xy(string tmpName, int tmpX, int tmpY)
        {
            connection.Open();
            string sql = "Insert into pinsTable (name, x, y) VALUES (@name, @x, @y)";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            
            cmd.Parameters.AddWithValue("@name",tmpName);
            cmd.Parameters.AddWithValue("@x",tmpX);
            cmd.Parameters.AddWithValue("@y",tmpY);
            Console.WriteLine("tmpname: " + tmpName);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult TourMaker()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        public void Test(string printString)
        {
            Console.WriteLine(printString);
        }
    }
}