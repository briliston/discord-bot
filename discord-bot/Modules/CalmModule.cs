using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Webhook;
using Discord.Audio;
using Discord.Rest;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using Discord;

namespace discord_bot.Modules
{
    public class CalmModule : ModuleBase<SocketCommandContext>
    {
        [Command("calm")]
        [Summary("Help the targeted user calm down.")]
        public async Task CalmAsync([Summary("User who needs help calming down.")] SocketUser user = null)
        {
            var userInfo = user ?? Context.User;
            await ReplyAsync($"Holy shit {userInfo.Username}, you need to calm down. I removed you from the chat before you said something you'd regret.");
        }

    }
}
