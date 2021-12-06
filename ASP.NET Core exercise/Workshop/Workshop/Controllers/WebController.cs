using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {

        [HttpGet("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = "from the model",               
            };

            return View(greeting);
        }
    }
}
