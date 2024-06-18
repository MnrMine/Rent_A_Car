using Microsoft.AspNetCore.Mvc;

namespace Rent_A_Car.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchCar()
        {
            return View();
        }
        public IActionResult CarList()
        {
            return View();
        }
    }
}
