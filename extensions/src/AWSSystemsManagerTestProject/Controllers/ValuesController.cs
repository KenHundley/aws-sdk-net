using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace AWSSystemsManagerTestProject.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IOptionsSnapshot<ApplicationSettings> _applicationSettings;

        public ValuesController(IOptionsSnapshot<ApplicationSettings> applicationSettings)
        {
            _applicationSettings = applicationSettings;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {ApplicationSettings = _applicationSettings.Value});
        }
    }
}
