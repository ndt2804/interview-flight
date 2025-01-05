using Microsoft.AspNetCore.Mvc;

namespace testflights.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
