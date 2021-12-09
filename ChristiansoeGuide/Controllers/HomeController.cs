using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChristiansoeGuide.Services;

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
            service.DateTime();
            service.FetchFerryTimes();

            ViewBag.Message = service.timeToNextFerry;
            return View(service.ferryTimesList);
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
    }
}