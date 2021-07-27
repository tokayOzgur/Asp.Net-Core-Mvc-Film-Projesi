using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Get()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}