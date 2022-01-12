using GuardiansApp.Interfaces;
using GuardiansApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GuardiansApp.Controllers
{
    public class ApiGuardianController : Controller
    {

        private IDraxService DraxService { get; set; }
        private IAwsomeMixService AwsomeMixService { get; set; }
       
        public ApiGuardianController(IDraxService draxService, IAwsomeMixService awsomeMixService)
        {
            DraxService = draxService;
            AwsomeMixService = awsomeMixService;
        }
            
        [HttpGet("api/groot")]
        public IActionResult GrootTrainslator([FromQuery] string message)
        {
            if (message == null || message.Length == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "I am Groot!" });
            }

            return Ok(new Groot() { received = message, translated = "I am Groot!" });

        }

        [HttpGet("api/yondu")]
        public IActionResult GetYondusArrowSpeed([FromQuery] double distance, [FromQuery] double time)
        {
                        
            if (time == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill time" });
            }

            return Ok(new Yondu(distance, time));

        }

        [HttpGet("api/rocket")]
        public IActionResult AmmunitionStorage([FromHeader]Ship RocketsShip)
        
        {
            return Ok(new ShipCargoResponse(RocketsShip));
        }

        //not finished

        [HttpGet("api/rocket/fill")]
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

        [HttpGet("api/drax")]
        public IActionResult GetDraxCaloriesList()
        {
            var foods = DraxService.GetAllItems();

            return Ok(foods);
        }

        [HttpPost("api/drax/add")]
        public IActionResult AddItem([FromQuery] string name, [FromQuery] int amount, [FromQuery] int calorie)
        {
            if (name == null || amount == 0 || calorie == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill name, amount and calories." });
            }

            var response = DraxService.Add(name, amount, calorie);
            return Ok(response);

        }

        [HttpDelete("api/drax/delete")]
        public IActionResult DeleteItem([FromQuery] int id)
        {
            List<int> ids = DraxService.GetAllIds();

            if (!ids.Contains(id))
            {
                return BadRequest(new ErrorResponse() { Error = "Wrong id" });
            }

            var response = DraxService.Delete(id);

            return Ok(response);
        }

        [HttpPut("api/drax/update")]
        public IActionResult UpdateAmount([FromQuery] int id, [FromQuery] int amount)
        {
            List<int> ids = DraxService.GetAllIds(); ;

            if (!ids.Contains(id))
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

        [HttpGet("api/awsome")]
        public IActionResult GetAwsomeMix()
        {
            var response = AwsomeMixService.GetAllSongs();

            return Ok(response);
        }

        [HttpPost("api/awsome/add")]
        public IActionResult AddSong([FromQuery] string author, [FromQuery] string title, [FromQuery] string genre, [FromQuery] int year, [FromQuery] int rating)
        {
            if (author == null || title == null)
            {
                return BadRequest( new ErrorResponse() { Error = "You have to fill author and title." }) ;
            }

            var song = AwsomeMixService.Add(author, title, genre, year, rating);

            return Ok(song);
        }

        [HttpDelete("api/awsome/delete")]
        public IActionResult DeleteSong([FromQuery] int id)
        {
            List<int> ids = AwsomeMixService.GetAllIds();

            if (!ids.Contains(id))
            {
                return BadRequest(new ErrorResponse() { Error = "Wrong id" });
            }

            var response = AwsomeMixService.Delete(id);

            return Ok(response);
        }

        [HttpPut("api/awsome/edit")]
        public IActionResult EditRating([FromQuery] int id, [FromQuery] int rating)
        {
            List<int> ids = AwsomeMixService.GetAllIds();

            if (id == 0 || !ids.Contains(id))
            {
                return BadRequest(new ErrorResponse() { Error = "Wrong id" });
            }

            var response = AwsomeMixService.EditRating(id, rating);

            return Ok(response);
        }

        [HttpGet("api/awsome/favorite")]
        public IActionResult FavoriteSongs([FromQuery] int number)
        {
            if (number == 0)
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill number" });
            }

            var response = AwsomeMixService.GetFavorite(number);

            return Ok(response);
        }

        [HttpGet("api/awsome/author")]
        public IActionResult AuthorsSongs([FromQuery] string author)
        {
            if (string.IsNullOrEmpty(author))
            {
                return BadRequest(new ErrorResponse() { Error = "You have to fill author"});
            }

            List<string> auth = AwsomeMixService.GetAllAuthours();
            if (!auth.Contains(author))
            {
                return BadRequest(new ErrorResponse() { Error = "Author not found" });
            }

            var response = AwsomeMixService.GetByAuthor(author);
            return Ok(response);
        }
    }
}
