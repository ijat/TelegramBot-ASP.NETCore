using Microsoft.AspNetCore.Mvc;

namespace TelegramBotASPnetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Test")]
    public class TestController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "1";
        }
    }
}