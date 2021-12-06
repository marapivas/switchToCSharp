using Microsoft.AspNetCore.Mvc;
using System;
using Workshop.Models;

namespace Workshop.Controllers
{
    [Route("")]
    public class HelloController : Controller
    {
        static string[] hellos = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
                "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
                "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
                "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};

        Random random = new Random();
        //public IActionResult Index()
        //{
        //    return View("HelloAllTheWorld");
        //}

        [HttpGet("world")]
        public IActionResult WorldGreeting([FromQuery] string name)
        {

            Random random = new Random();
            int rnd = random.Next(hellos.Length);

            Greeting worldGreeting = new Greeting($"{hellos[rnd]}, {name}!");



            return View("Hello", worldGreeting);
        }
    }
}
