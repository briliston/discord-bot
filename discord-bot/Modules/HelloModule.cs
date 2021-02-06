using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace discord_bot.Modules
{
    public class HelloModule : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        [Summary("Have the bot say hello!")]
        public async Task TestAsync([Summary("The user to say hello to.")] SocketUser user = null)
        {
            var userInfo = user ?? Context.User;
            await ReplyAsync($"Hello {userInfo.Username}, I'm Bri's bot. Nice to meet you!");
        }
    }
}
