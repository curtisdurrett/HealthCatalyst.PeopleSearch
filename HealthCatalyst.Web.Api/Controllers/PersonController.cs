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

            var ret = await _personSearchService.SearchByName(searchString);

            return Ok(ret);
        }

        // GET api/values
        [HttpGet("seedData")]
        public async Task<IActionResult> seedData()
        {
            //int recordsInserted = await _personDataSeederService.SeedData();
            //return Ok();
            return null;
        }
    }
}
