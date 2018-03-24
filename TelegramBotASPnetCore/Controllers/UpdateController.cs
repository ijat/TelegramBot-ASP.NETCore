using Microsoft.AspNetCore.Mvc;
using TelegramBotASPnetCore.Services;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotASPnetCore.Controllers
{
    [Route("api/telebot/[controller]")]
    public class UpdateController : Controller
    {
        private static readonly int MAX_CHAR = 4095;
        readonly IBotService _botService;
        readonly BotConfiguration _config;
        readonly TelegramBotClient bot;

        public UpdateController(BotConfiguration config, IBotService botService)
        {
            _config = config;
            _botService = botService;
            bot = _botService.Client;
        }

        [HttpPost]
        public void Post([FromBody]Update e)
        {
            bot.SendTextMessageAsync(e.Message.From.Id, "Ping!");
        }
    }
}