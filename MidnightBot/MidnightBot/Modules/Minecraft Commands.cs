using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace MidnightBot.Modules.Minecraft_Commands
{
    public class MinecraftCommands : ModuleBase<SocketCommandContext>
    {
        [Command("mchelp")]
        [Summary("Gets list of GameOut Minecraft Server commands sent to Discord User's DM's.")]
        public async Task McHelp()
        {
            EmbedBuilder b = new EmbedBuilder();

            b.WithTitle("GameOut Commands");

            b.AddInlineField("/vote", "Provides the voting websites for the GameOut Minecraft server!").WithColor(25, 25, 112);

            b.AddInlineField("/website", "Get a link for the server's main website!");

            b.AddInlineField("/revip", "Shows the ip for the FTB Revelations server!");

            IDMChannel augur = await Context.Message.Author.GetOrCreateDMChannelAsync();

            await augur.SendMessageAsync("", false, b);
            await augur.CloseAsync();
        }

        [Command("vote")]
        [Summary("Provides the voting websites for the GameOut Minecraft server!")]
        public async Task Vote()
        {
            var b = new Discord.EmbedBuilder();

            b.WithTitle("Don't Forget To Vote For Amazing Rewards At The Following Websites!");
            b.WithDescription("Vote Link 1 : \n https://ftbservers.com/server/dzZfMJNd/vote \n" +
                "Vote Link 2 : \n https://www.planetminecraft.com/server/game-out-network/vote/ \n" +
                "Vote Link 3 : \n http://minecraft-mp.com/server/191690/vote/");
            b.WithColor(new Discord.Color(0, 170, 255));

            await Context.Channel.SendMessageAsync("", false, b);
        }

        [Command("website")]
        [Summary("Get a link for the server's main website!")]
        public async Task Website()
        {
            var b = new EmbedBuilder();

            b.WithTitle("Come Check Us Out On The Homefront!");
            b.WithDescription("https://gameoutftb.enjin.com/");
            b.WithColor(new Discord.Color(0, 170, 255));

            await Context.Channel.SendMessageAsync("", false, b);
        }

        [Command("revip")]
        [Summary("Shows the ip for the FTB Revelations server!")]
        public async Task RevIp()
        {
            var b = new Discord.EmbedBuilder();

            b.WithTitle("Here's the ip for the FTB Revelations server!");
            b.WithDescription("rev.gameoutnetwork.com");
            b.WithColor(new Discord.Color(0, 170, 255));

            await Context.Channel.SendMessageAsync("", false, b);
        }
    }
}