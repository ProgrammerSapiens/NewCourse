using Microsoft.AspNetCore.Mvc;

namespace WebDevelopmentAndAPI.FirstDay.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello from custom route");
        }
    }
}
