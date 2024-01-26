using Microsoft.AspNetCore.Mvc;

namespace GoodPatient.MVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult Post1()
        {
            return View();
        }

        public IActionResult Post2()
        {
            return View();
        }
        public IActionResult Post3()
        {
            return View();
        }
    }
}
