using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace MidnightBot.Modules.Experiments
{
    public class Experiments : ModuleBase<SocketCommandContext>
    {
        [Group("binary")]
        [Summary("Encodes and decodes text to and from binary.")]
        public class Binary : ModuleBase<SocketCommandContext>
        {
            [Command("decode")]
            [Summary("Decodes text from binary.")]
            public async Task Decode(string data)
            {
                List<Byte> byteList = new List<Byte>();

                for (int i = 0; i < data.Length; i += 8)
                {
                    byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
                }

                string endres = Encoding.ASCII.GetString(byteList.ToArray());

                var b = new Discord.EmbedBuilder();

                b.AddInlineField("The Binary Code Given To Me", data);
                b.AddInlineField("The Text", endres);

                await ReplyAsync("", false, b);
            }

            [Command("encode")]
            [Summary("Encodes text to binary.")]
            public async Task Encode([Remainder]string data)
            {
                StringBuilder sb = new StringBuilder();

                foreach (char c in data.ToCharArray())
                {
                    sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                }

                string endres = sb.ToString();

                var b = new Discord.EmbedBuilder();
                b.AddInlineField("The Text Given To Me", data);
                b.AddInlineField("The Binary Code", endres);

                await ReplyAsync("", false, b);
            }
        }

        [Command ("getroles")]
        [Summary("Gets a list of roles of the inputted user.")]
        public async Task GetRoles([Remainder] SocketGuildUser user)
        {
            var name = user.ToString();

            var read = "";

            foreach (SocketRole role in user.Roles)
            {
                read = read + role.Name + "\n";
            }

            var a = new EmbedBuilder();

            a.AddField(name, read);

            await ReplyAsync("", false, a);
        }

        [Command ("ping")]
        [Summary("Pings the inputted user.")]
        public async Task Ping([Remainder] SocketGuildUser user)
        {
            await ReplyAsync(user.Mention);
        }
    }
}