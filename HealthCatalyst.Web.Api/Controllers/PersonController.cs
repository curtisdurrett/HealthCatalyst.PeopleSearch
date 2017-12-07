using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

using HealthCatalyst.Services;

namespace HealthCatalyst.Web.Api.Controllers
{
    [Route("api/v1/person")]
    [EnableCors("AllowAny")]
    public class PersonController : Controller
    {
        private readonly IPersonSearchService _personSearchService;
        private readonly IPersonDataSeederService _personDataSeederService;

        public PersonController(
            IPersonSearchService personSearchService,
            IPersonDataSeederService personDataSeederService)
        {
            _personSearchService = personSearchService;
            _personDataSeederService = personDataSeederService;
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

            var ret = await _personSearchService.SearchByName(searchString);

            return Ok(ret);
        }

        // GET api/values
        [HttpGet("seedData")]
        public async Task<IActionResult> SeedData()
        {
            int recordsInserted = await _personDataSeederService.SeedData();
            return Ok();
        }
    }
}
