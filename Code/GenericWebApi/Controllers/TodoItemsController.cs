using Microsoft.AspNetCore.Mvc;
using Repository.Repositories;

namespace GenericWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoItemsController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly UserProfileRepo _userProfileRepo;

        public TodoItemsController(ILogger<WeatherForecastController> logger,
            UserProfileRepo userProfileRepo)
        {
            _logger = logger;
            _userProfileRepo = userProfileRepo;
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

        [HttpGet("test-user-profiles")]
        public IActionResult ListUserProfiles()
        {
            return Ok(_userProfileRepo.GetAll().ToList());
        }

    }
}
