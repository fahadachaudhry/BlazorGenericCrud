using Microsoft.AspNetCore.Mvc;

namespace GenericWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoItemsController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public TodoItemsController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("all")]
        public List<string> Get()
        {
            return new List<string>
            {
                "value1",
                "value2",
                "value3",
                "value4",
                "value5",
            };
        }

    }
}
