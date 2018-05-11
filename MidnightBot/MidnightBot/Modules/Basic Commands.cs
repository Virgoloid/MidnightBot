using System;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace MidnightBot.Modules.Basic_Commands
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        [Summary("Gets list of Base Help commands sent to Discord User's DM's.")]
        public async Task Help()
        {
            var a = new Discord.EmbedBuilder();

            a.AddInlineField("/mchelp", "Gets the list of GameOut Minecraft Server commands.").WithColor(25, 25, 112);

            a.AddInlineField("/adhelp", "Gets the list of bot owner commands.");

            a.AddInlineField("/reee", "For when autism strikes.");

            a.AddInlineField("/insult", "For when you wanna insult someone.");

            a.AddInlineField("/killme", "For when you wanna die.");

            a.AddInlineField("/8ball", "For when autism strikes.");

            a.AddInlineField("/tellajoke", "Tells a joke.");

            a.AddInlineField("/rate + WhatYouWantRatedHere", "Rates the input.");

            a.AddInlineField("/stats", "Receives bot stats.");

            a.AddInlineField("/get time", "Gets the current time.");

            a.AddInlineField("/get date", "Gets the current date.");

            IDMChannel gencom = await Context.Message.Author.GetOrCreateDMChannelAsync();

            await gencom.SendMessageAsync("", false, a);
            await gencom.CloseAsync();
        }

        [Command("reee")]
        [Summary("For when autism strikes.")]
        public async Task Reee()
        {
            var b = new Discord.EmbedBuilder();

            b.WithDescription("REEEEEEEEEEEEEEEEEEEEEEEEEEEEE! :kissing_closed_eyes: ");
            b.WithColor(new Discord.Color(0, 170, 255));

            await Context.Channel.SendMessageAsync("", false, b);
        }

        [Command("insult")]
        [Summary("For when you wanna insult someone. Insult Count : 21")]
        public async Task Insult()
        {
            Random rnd = new Random();

            int ball = rnd.Next(1, 22);

            if (ball == 1)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Ur mom gay lol. :laughing:  ");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 2)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Your mom is rated E for everyone.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 3)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("You're only here because your mother didn't want to ruin her lipstick.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 4)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I would insult your mother, but cows are sacred in my country.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 5)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Villain, I have done thy mother!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 6)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Thou elvish-mark'd, abortive, rooting hog!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 7)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Thou art rankest compound of villainous smell that ever offended nostril!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 8)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Away, you three-inch fool!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 9)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I need some chemo for the cancer you're bringing.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 10)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Thou sodden-witted lord! Thou hast no more brain than I have in mine elbows");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 11)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("He’s always lost in thought. It’s unfamiliar territory.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 12)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Your ass must be pretty jealous of all the shit that comes out of your mouth.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 13)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I’m trying my absolute hardest to see things from your perspective, but I just can’t get my head that far up my ass.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 14)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("You should be featured in Logan Paul's next forest video");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 15)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Out of 100,000 sperm, you were the fastest?");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 16)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I hear when you were a child your mother wanted to hire somebody to take care of you, but the mafia wanted too much.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 17)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Hey, you have something on your chin...3rd one down.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 18)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I know not the difference between thy neck and chin.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 19)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Why don't you slip into something more comfortable? Like a coma.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 20)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Why don't you check on eBay and see if they have a life for sale?");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("You're a diabetic Pringle.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
        }

        [Command("killme")]
        [Summary("For when you wanna die.")]
        public async Task KillMe()
        {
            var b = new Discord.EmbedBuilder();

            b.WithDescription("heheheheheh.............:sob:");
            b.WithColor(new Discord.Color(0, 170, 255));

            await Context.Channel.SendMessageAsync("", false, b);
        }

        [Command("8ball")]
        [Summary("Asks the 8ball a question. Response Count : 17")]
        public async Task EightBall([Remainder]string ballquestion)
        {
            Random rnd = new Random();

            int ball = rnd.Next(1, 18);

            if (ball == 1)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Yes!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 2)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("No!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 3)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Of course!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 4)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("There's no way in hell!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 5)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Maybe.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 6)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I think so.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 7)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I don't think so.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 8)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("God would say yes.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 9)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("God would say no.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 10)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Certainly.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 11)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I certainly think otherwise.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 12)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I wouldn't count on it.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 13)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I'd count on it.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 14)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("From what I can tell? Yes.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 15)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("From what I can tell? No.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 16)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I think there's a chance.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I don't think there's a chance.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
        }

        [Command("tellajoke")]
        [Summary("Tells a joke. Joke Count : 20")]
        public async Task TellAJoke()
        {
            Random rnd = new Random();

            int ball = rnd.Next(1, 21);

            if (ball == 1)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Three Germans walk into a BAR.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 2)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("What's the best thing about Switzerland? I dunno, but the flag is a big plus.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 3)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I invented a new word! Plagiarism!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 4)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Did you hear about the mathematician who's afraid of negative numbers? He'll stop at nothing to avoid them.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 5)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("My existence... :sob:");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 6)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Your existence. :ok_hand:");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 7)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("If the Silver Surfer and Iron Man team up, they’d be alloys.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 8)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Making bad chemistry jokes because all the good ones Argon");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 9)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Why was the mole of oxygen molecules excited when he walked out of the singles bar? He got Avogadro's number!");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 10)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("A neutron walks into a bar. He asks the bartender, \"How much for a beer?\" The bartender offers him a warm smile and says, \"For you, no charge\".");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 11)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("What do you do with a dead chemist? Barium.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 12)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Why did the chemist sole and heel his shoes with silicone rubber? To reduce his carbon footprint.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 13)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("What do you call a tooth in a glass of water? A one molar solution.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 14)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("If you're not part of the solution, you're part of the precipitate.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 15)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("What happened to the man who was stopped for having sodium chloride and a nine-volt in his car? He was booked for a salt and battery.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 16)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("What kind of fish is made out of 2 sodium atoms? 2 Na");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 17)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("A friend of mine tried to solve a Chemistree problem, but he got stumped.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 18)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("I heard Oxygen and Magnesium were going out and I was like \"OMg\".");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else if (ball == 19)
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("When I try to tell Chemistry jokes, I get no reaction.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
            else
            {
                var b = new Discord.EmbedBuilder();

                b.WithDescription("Feminism.");
                b.WithColor(new Discord.Color(0, 170, 255));

                await Context.Channel.SendMessageAsync("", false, b);
            }
        }

        [Command("rate")]
        [Summary("Rates the input.")]
        public async Task Rate([Remainder]string rquestion)
        {
            Random rnd = new Random();

            int rating = rnd.Next(1, 11);

            var b = new Discord.EmbedBuilder();

            b.WithDescription("I give " + rquestion + " a " + rating + " out of 10");
            b.WithColor(new Discord.Color(0, 170, 255));

            await Context.Channel.SendMessageAsync("", false, b);
        }

        [Command("stats")]
        [Summary("Receives bot stats.")]
        public async Task Stats()
        {
            var time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            var guildamount = Context.Client.Guilds.Count();

            var aceuseramount = Context.Client.GetGuild(247815199539593216).DownloadedMemberCount;

            var myuseramount = Context.Client.GetGuild(421126146147745792).DownloadedMemberCount;

            var useramount = aceuseramount + myuseramount;

            EmbedBuilder a = new EmbedBuilder();

            a.AddInlineField("Bot Name", "Midnight Bot").WithColor(25, 25, 112);

            a.AddInlineField("Bot ID", "431471329389182976");

            a.AddInlineField("Owner", "Virgo");

            a.AddInlineField("Owner ID", "181851463000129538");

            a.AddInlineField("Guilds", guildamount);

            a.AddInlineField("Users", useramount);

            a.AddInlineField("Current Date And Time", time);

            a.AddInlineField("Command Prefix", "/");

            await ReplyAsync("", false, a);
        }

        [Group("get")]
        [Summary("Get the current time or date.")]
        public class Get : ModuleBase<SocketCommandContext>
        {
            [Command("time")]
            [Summary("Gets the current time.")]
            public async Task Time()
            {
                var current = DateTime.Now.ToString("h:mm tt");

                await ReplyAsync("The time is currently " + current);
            }

            [Command("date")]
            [Summary("Gets the current date.")]
            public async Task Date()
            {
                var current = DateTime.Now.ToString("MM/dd/yyyy");

                await ReplyAsync("Today's date is " + current);
            }
        }
    }
}