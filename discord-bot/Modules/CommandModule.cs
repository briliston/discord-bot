using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace discord_bot.Modules
{
    public class CommandModule : ModuleBase<SocketCommandContext>
    {
        [Command("commands")]
        [Summary("What commands does this bot use?")]
        public async Task o7Async()
        {
            await ReplyAsync("!hello\n!help [the question you want answered]\no7\n");
        }
    }
}