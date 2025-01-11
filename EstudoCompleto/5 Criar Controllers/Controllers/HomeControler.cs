using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    public class HomeControler:ControllerBase
    {    //Halth-check
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
