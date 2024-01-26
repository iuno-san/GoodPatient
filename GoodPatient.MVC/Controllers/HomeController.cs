using Microsoft.AspNetCore.Mvc;
using GoodPatient.Models;
using System.Diagnostics;

namespace GoodPatient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult Terms()
        {
            return View();
        }

        public IActionResult Docs()
        {
            return View();
        }
        public IActionResult PlanSection()
        {
            return View();
        }

        public IActionResult NoAccess()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statuscode)
        {
            if(statuscode == 404)
            {
                return View("NotFound");
            }
            else
            {
				return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
			}
        }
    }
}
