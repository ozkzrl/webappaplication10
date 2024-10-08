using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class Gameroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
