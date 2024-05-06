using Microsoft.AspNetCore.Mvc;

namespace Purple_buzz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
