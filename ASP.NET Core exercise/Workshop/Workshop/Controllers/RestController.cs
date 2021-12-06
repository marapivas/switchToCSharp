using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        static int Counter = 1;

        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {
            
            Greeting hello = new Greeting(Counter, $"Hello, {name}!" );
            Counter++;

            return hello;
           

        }
    }
}
