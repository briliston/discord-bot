using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace discord_bot.Modules
{
    public class SaluteModule : ModuleBase<SocketCommandContext>
    {
        [Command("7")]
        [Summary("Salute")]
        public async Task o7Async()
        {
            await ReplyAsync("o7");
        }
    }
}
