using System;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChristiansoeGuide.Models;
using ChristiansoeGuide.Services;
using MySql.Data.MySqlClient;

namespace ChristiansoeGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Service service = new Service();
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            service.DateTimeTest();
            service.FetchFerryTimes();

            ViewBag.Message = service.timeToNextFerry;
            return View(service.ferryTimesList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult TourMaker()
        {
            service.FetchTourList();
            return View(service.tourList);
        }

        public void AddTourToDatabase(string tmpName, int tmpX, int tmpY)
        {
            service.AddTourToDatabase(tmpName, tmpX, tmpY);
        }

        public void ClearTour()
        {
            service.ClearTour();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}