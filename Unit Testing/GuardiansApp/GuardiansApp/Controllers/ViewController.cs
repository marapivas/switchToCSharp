using GuardiansApp.Database;
using GuardiansApp.Interfaces;
using GuardiansApp.Models;
using GuardiansApp.Models.ViewModels;
using GuardiansApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuardiansApp.Controllers
{
    [Route("")]
    public class ViewController : Controller
    {
        private IDraxService DraxService { get; set; }
        private IAwsomeMixService AwsomeMixService { get; set; }

        public ViewController(IDraxService draxService, IAwsomeMixService awsomeMixService)
        {
            DraxService = draxService;
            AwsomeMixService = awsomeMixService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("groot")]
        public IActionResult GrootTrainslatorForm([FromForm] string message)
        {
            if (message == null || message.Length == 0)
            {
                var error = new IndexViewModel { Error = "I am Groot!" };

                return View("Index", error);
            }
            var translate = new IndexViewModel() { Groot = new Models.Groot() { received = message, translated = "I am Groot!" } };
            return View("Index", translate);
        }

        [HttpPost("yondu")]
        public IActionResult YondusArrowSpeed([FromForm] double distance, [FromForm] double time)
        {
            if (time == 0)
            {
                var error = new IndexViewModel { Error = "You have to fill time" };

                return View("Index", error);
            }
            var speed = new IndexViewModel() { Yondu = new Models.Yondu(distance, time) };

            return View("Index", speed);
        }

        [HttpGet("drax")]
        public IActionResult DraxCaloriesList()
        {
            var foodList = new DraxViewModel() { FoodListResponse = DraxService.GetAllItems() };
            return View("DraxCaloriesTable", foodList);
        }

        [HttpGet("drax/add")]
        public IActionResult DraxAddNewFoodForm()
        {
            return View("AddNewFood");
        }

        [HttpPost("drax/add")]
        public IActionResult DraxAddNewFood([FromForm] string name, [FromForm] int amount, [FromForm] int calorie)
        {
            var newfood = new DraxViewModel() { FoodListResponse = DraxService.Add(name, amount, calorie) };
            return View("DraxCaloriesTable");
        }

        [HttpGet("awsome")]
        public IActionResult AwsomeMixList()
        {
            var songList = new AwsomeMixViewModel() { SongList = AwsomeMixService.GetAllSongs() };

            return View("AwsomeMixTable", songList);
        }
    }
}
