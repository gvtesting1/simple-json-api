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
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "sample.json");
            var jsonData = await System.IO.File.ReadAllTextAsync(filePath);
            return Content(jsonData, "application/json");
        }

        [HttpGet("GetPerson")]
        public async Task<IActionResult> GetPerson()
        {
            //create an object to hold person information
            var person = new
            {
                Name = "Gabriel Valadez",
                Age = 25,
                Email = "gabriel.valadez@gmail.com"
            };
            var jsonData = JsonSerializer.Serialize(person);

            return Content(jsonData, "application/json");
        }
    }
}