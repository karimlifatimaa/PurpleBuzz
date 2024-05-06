using Microsoft.AspNetCore.Mvc;

namespace Purple_buzz.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
