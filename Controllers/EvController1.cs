using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    public class EvController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
