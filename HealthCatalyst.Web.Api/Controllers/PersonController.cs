using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

using HealthCatalyst.Services;
using HealthCatalyst.Data;
using HealthCatalyst.Domain.Models;

namespace HealthCatalyst.Web.Api.Controllers
{
    [Route("api/v1/person")]
    [EnableCors("AllowAny")]
    public class PersonController : Controller
    {
        private readonly IPersonSearchService _personSearchService;

        public PersonController(
            IPersonSearchService personSearchService)
        {
            _personSearchService = personSearchService;
        }
        
        // GET api/values
        [HttpGet("searchByName/{searchString}")]
        [AcceptVerbs]
        public async Task<IActionResult> SearchByName(string searchString)
        {

            if (string.IsNullOrWhiteSpace(searchString))
            {
                return BadRequest(new { message = $"'{nameof(searchString)}' is required." });
            }

            //var daPeople = await _personRepo.SearchByName(name);

            //System.Threading.Thread.Sleep(5000);

            var ret = await _personSearchService.SearchByName(searchString);

            return Ok(ret);
        }

        // GET api/values
        [HttpGet("seedData")]
        public async Task<IActionResult> seedData()
        {
            int count = 0;
            using (var db = new DatabaseContext())
            {
                var rows = from o in db.Persons
                    select o;
                foreach (var row in rows)
                {
                    db.Persons.Remove(row);
                }
                db.SaveChanges();

                db.Persons.Add(new Person
                {
                    FirstName = "Chris1",
                    LastName = "Peele",
                    DateOfBirth = new DateTime(1974, 5, 12),
                    Interests = "old movies, Iot",
                    PictureFileName = "ChrisPeele.jpg",
                    AddressLine1 = "709 Pony Street",
                    AddressLine2 = null,
                    City = "Harker Heights",
                    State = "TX",
                    Zip = "76523"
                });

                db.Persons.Add(new Person
                {
                    FirstName = "Daniel1",
                    LastName = "Durrett",
                    DateOfBirth = new DateTime(2002, 2, 21),
                    Interests = "welding, computer games",
                    PictureFileName = "DanielDurrett.jpg",
                    AddressLine1 = "3309 De Leon Cir",
                    AddressLine2 = null,
                    City = "Belton",
                    State = "TX",
                    Zip = "76513"
                });

                db.Persons.Add(new Person
                {
                    FirstName = "Christopher1",
                    LastName = "Durrett",
                    DateOfBirth = new DateTime(2004, 6, 8),
                    Interests = "reading, chess, band",
                    PictureFileName = "ChristopherDurrett.jpg",
                    AddressLine1 = "3309 DeLeon Cir",
                    AddressLine2 = null,
                    City = "Belton",
                    State = "TX",
                    Zip = "76513"
                });

                count = db.SaveChanges();
            }

            return Ok("{'recordsInserted':0}");
        }
    }
}
