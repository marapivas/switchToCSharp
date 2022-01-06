using GuardiansApp.Database;
using GuardiansApp.Models;
using GuardiansApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuardiansApp.Controllers
{
    public class GuardianController : Controller
    {

        private DraxService DraxService { get; set; }
        private AwsomeMixService AwsomeMixService { get; set; }
        private ApplicationDbContext DbContext { get; set; }

        public GuardianController(DraxService draxService, AwsomeMixService awsomeMixService, ApplicationDbContext dbContext)
        {
            DraxService = draxService;
            AwsomeMixService = awsomeMixService;
            DbContext = dbContext;
        }
            
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("groot")]
        public IActionResult GrootTrainslator([FromQuery] string message)
        {
            if (message == null || message.Length == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "I am Groot!" });
            }

            return Ok(new Groot() { received = message, translated = "I am Groot!" });

        }

        [HttpGet("yondu")]
        public IActionResult GetYondusArrowSpeed([FromQuery] double distance, [FromQuery] double time)
        {
                        
            if (time == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill time" });
            }

            return Ok(new Yondu(distance, time));

        }

        [HttpGet("rocket")]
        public IActionResult AmmunitionStorage([FromHeader]Ship RocketsShip)
        
        {
            return Ok(new ShipCargoResponse(RocketsShip));
        }

        //not finished

        [HttpGet("rocket/fill")]
        public IActionResult FillAmmunition([FromQuery] string caliber, 
                                            [FromQuery] int amount, 
                                            [FromHeader] Ship RocketsShip)
        {
            if (string.IsNullOrEmpty(caliber))
            {
                return BadRequest(new { error = "You have to fill caliber" });
            }

            if (caliber.Contains("25"))
            {
                RocketsShip.caliber25 += amount;
                RocketsShip.ShipStatusUpdate();
                RocketsShip.StorageUpdate();

                var response = new ShipFillStatusResponse()
                {
                    recived = caliber,
                    amount = amount,
                    shipstatus = RocketsShip.shipstatus,
                    ready = RocketsShip.ready
                };


                return Ok(response);
            }

            if (caliber.Contains("30"))
            {

            }

            if (caliber.Contains("50"))
            {

            }
            return null;
        }

        [HttpGet("drax")]
        public IActionResult GetDraxCaloriesList()
        {
            var foods = DraxService.GetAllItems();

            return Ok(foods);
        }

        [HttpPost("drax/add")]
        public IActionResult AddItem([FromQuery] string name, [FromQuery] int amount, [FromQuery] int calorie)
        {
            if (name == null || amount == 0 || calorie == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill name, amount and calories." });
            }

            var response = DraxService.Add(name, amount, calorie);
            return Ok(response);

        }

        [HttpDelete("drax/delete")]
        public IActionResult DeleteItem([FromQuery] int id)
        {
            List<int> ids = DbContext.Foods.Select(x => x.Id).ToList();

            if (id == 0 || !ids.Contains(id))
            {
                return BadRequest(new ErrorResponse() { Error = "Wrong id" });
            }

            var response = DraxService.Delete(id);

            return Ok(response);
        }

        [HttpPut("drax/update")]
        public IActionResult UpdateAmount([FromQuery] int id, [FromQuery] int amount)
        {
            List<int> ids = DbContext.Foods.Select(x => x.Id).ToList();

            if (id == 0 ||  !ids.Contains(id))
            {
                return BadRequest(new ErrorResponse() { Error = "Wrong id" });
            }

            if (amount == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill new amount"});
            }

            var response = DraxService.Edit(id, amount);

            return Ok(response);
        }

        [HttpGet("awsome")]
        public IActionResult GetAwsomeMix()
        {
            var response = AwsomeMixService.GetAllSongs();

            return Ok(response);
        }

        [HttpPost("awsome/add")]
        public IActionResult AddSong([FromQuery] string author, [FromQuery] string title, [FromQuery] string genre, [FromQuery] int year, [FromQuery] int rating)
        {
            if (author == null || title == null)
            {
                return BadRequest( new ErrorResponse() { Error = "You have to fill author and title." }) ;
            }

            var song = AwsomeMixService.Add(author, title, genre, year, rating);

            return Ok(song);
        }

        [HttpDelete("awsome/delete")]
        public IActionResult DeleteSong([FromQuery] int id)
        {
            List<int> ids = DbContext.Songs.Select(x => x.Id).ToList();

            if (id == 0 || !ids.Contains(id))
            {
                return BadRequest(new ErrorResponse() { Error = "Wrong id" });
            }

            var response = AwsomeMixService.Delete(id);

            return Ok(response);
        }

        [HttpPut("awsome/edit")]
        public IActionResult EditRating([FromQuery] int id, [FromQuery] int rating)
        {
            List<int> ids = DbContext.Songs.Select(x => x.Id).ToList();

            if (id == 0 || !ids.Contains(id))
            {
                return BadRequest(new ErrorResponse() { Error = "Wrong id" });
            }

            var response = AwsomeMixService.EditRating(id, rating);

            return Ok(response);
        }

        [HttpGet("awsome/favorite")]
        public IActionResult FavoriteSongs([FromQuery] int number)
        {
            if (number == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill number" });
            }

            var response = AwsomeMixService.GetFavorite(number);

            return Ok(response);
        }

        [HttpGet("awsome/author")]
        public IActionResult AuthorsSongs([FromQuery] string author)
        {
            if (string.IsNullOrEmpty(author))
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill author"});
            }

            List<string> auth = DbContext.Songs.Select(x => x.Author).ToList();
            if (!auth.Contains(author))
            {
                return BadRequest(new ErrorResponse() { Error = "Author not found" });
            }

            var response = AwsomeMixService.GetByAuthor(author);
            return Ok(response);
        }
    }
}
