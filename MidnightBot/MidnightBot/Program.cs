using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace TemplateBot
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().StartAsync().GetAwaiter().GetResult();
        }

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {

            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "TOKEN HERE");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);         
        }
    }
}