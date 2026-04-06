using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to Order Management System API");
        }

        [HttpGet(Name = "GetApiVersion")]
        public int GetApiVersion()
        {
            return 1;
        }
    }
}
