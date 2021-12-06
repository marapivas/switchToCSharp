using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    public class FizzBuzzWoofController : Controller
    {
        static int Counter = 1;

        [HttpGet("fizz")]
        public IActionResult FizzBuzzWoof([FromQuery] string name)
        {
            var greeting = new Greeting()
            {
                
            };
            
            greeting.Content = $"Hello, {name}! This site was loaded {greeting.Fizzbuzz(Counter)} times since last server start.";
            greeting.Id = Counter;

            Counter++;

            return View("FizzBuzzWoof", greeting);
        }


    }
}
