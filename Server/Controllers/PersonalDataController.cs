using BlazorTest.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTest.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PersonalDataController : ControllerBase
    {
        private static readonly List<PersonalData> Data = new();

        private readonly ILogger<WeatherForecastController> _logger;

        public PersonalDataController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void Post(PersonalData data)
        {
            Data.Add(data);
        }
    }
}
