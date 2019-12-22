using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greeting = "Greetings!";
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
