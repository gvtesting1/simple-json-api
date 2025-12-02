using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace SimpleJsonApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("GetJson")]
        public async Task<IActionResult> GetJson()
        {
            var people = new[]
            {
                new { Name = "Sherri", Age = 30 },
                new { Name = "Jestina", Age = 25 },
                new { Name = "Charlie", Age = 35 }
            };  
            var jsonData = JsonSerializer.Serialize(people);
            return Content(jsonData, "application/json");
            
        }

        [HttpGet("GetPerson")]
        public async Task<IActionResult> GetPerson()
        {
            //create an object to hold person information
            var person = new
            {
                Name = "Gabriel Valadez Moncayo",
                Age = 25,
                Email = "gabriel.valadez@ust.com"
            };
            var jsonData = JsonSerializer.Serialize(person);

            return Content(jsonData, "application/json");
        }
    }
}