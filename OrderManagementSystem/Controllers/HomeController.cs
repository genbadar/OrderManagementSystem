using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        // GET api/home
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to Order Management System API");
        }

        // GET api/home/version
        [HttpGet("version")]
        public IActionResult GetApiVersion()
        {
            return Ok(1);
        }
    }
}
