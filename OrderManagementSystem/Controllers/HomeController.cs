using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
