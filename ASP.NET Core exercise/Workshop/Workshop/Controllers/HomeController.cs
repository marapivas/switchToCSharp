using Microsoft.AspNetCore.Mvc;

namespace Workshop.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        public string Index()
        {
            return "Hello from the Controller!";
        }

    }
}
