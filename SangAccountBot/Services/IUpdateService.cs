using Telegram.Bot.Types;

namespace TelegramBotASPnetCore.Services
{
    public interface IUpdateService
    {
        void OnMessageReceiveQueue(Update update);
    }
}
