using Discord.WebSocket;
using Discord.Commands;
using System.Reflection;
using System.Threading.Tasks;
using System;

namespace TemplateBot
{
    class CommandHandler 
    {
        private DiscordSocketClient _client;

        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;

            if (msg == null) return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;

            if (msg.HasStringPrefix("/", ref argPos))
            {
                //Logs Command Use--------------------------------------------
                var username = context.User.Username;

                var userid = context.User.Id;

                var time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Brandon\Desktop\MidnightBot\MidnightBot\log.txt", true))
                {
                    file.WriteLine(msg + " Was used by " + username + "(" + userid + ") on " + time + "\n");
                } 
                //------------------------------------------------------------

                var result = await _service.ExecuteAsync(context, argPos);

                if (!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                {
                    await context.Channel.SendMessageAsync(result.ErrorReason);
                }
            }
        }
    }
}