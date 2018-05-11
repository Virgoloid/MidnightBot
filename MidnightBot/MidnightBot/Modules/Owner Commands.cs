using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace MidnightBot.Modules.Owner_Commands
{
    public class OwnerCommands : ModuleBase<SocketCommandContext>
    {
        [Command("adhelp")]
        [Summary("Gets list of owner commands sent to Discord User's DM's.")]
        [RequireOwner]
        public async Task AdHelp()
        {
                EmbedBuilder b = new EmbedBuilder();

                b.WithTitle("Owner Commands");

                b.AddInlineField("/kick + User + ReasonForKickHere", "Kicks the inputted user with an explanation.").WithColor(25, 25, 112);

                b.AddInlineField("/leave", "Makes the bot leave the current server.");

                b.AddInlineField("/playing + WhateverYouWantItToPlayHere", "Sets the bot's playing status to whatever is input.");

                b.AddInlineField("/message + channelID + YourMessageHere", "Sends a message to the inputted channel id.");

                b.AddInlineField("/updateguildcount + channelID + YourMessageHere", "Updates the basic Guild Count and such in the Playing Property.");

                Discord.IDMChannel augur = await Context.Message.Author.GetOrCreateDMChannelAsync();

                await augur.SendMessageAsync("", false, b);
                await augur.CloseAsync();
        }

        [Command("kick")]
        [Summary("Kicks the inputted user with an explanation.")]
        [RequireOwner]
        public async Task Kick(Discord.IGuildUser user, [Remainder] string reason)
        {
                var b = new Discord.EmbedBuilder();

                b.WithTitle("User Kicked").WithDescription(user.Username + " was kicked because " + reason).WithColor(25, 25, 112);

                await Context.Channel.SendMessageAsync("", false, b);
                await user.KickAsync();
        }

        [Command("leave")]
        [Summary("Makes the bot leave the current server.")]
        [RequireOwner]
        public async Task Leave()
        {
                await ReplyAsync("**MidnightBot has left the server.**");

                await Context.Guild.LeaveAsync();
        }
        
        [Command("playing")]
        [Summary ("Sets the bot's playing status to whatever is input.")]
        [RequireOwner]
        public async Task Playing([Remainder] string playing)
        {
                await Context.Client.SetGameAsync(playing);
        }
        
        [Command("updateguildcount")]
        [Summary ("Updates the basic Guild Count and such in the Playing Property.")]
        [RequireOwner]
        public async Task UpdateGuildCount()
        {
                var guildamount = Context.Client.Guilds.Count();

                await Context.Client.SetGameAsync("/help | " + guildamount + " Guilds");
        }

        [Command("message")]
        [Summary("Sends a message to the inputted channel id.")]
        [RequireOwner]
        public async Task MessageAsync(ulong channelid, [Remainder] string message)
        {
                var chnl = Context.Client.GetChannel(channelid) as IMessageChannel;

                await chnl.SendMessageAsync(message);
        }
    }
}