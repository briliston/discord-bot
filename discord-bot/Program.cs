using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Configuration;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using System.Collections.Generic;

namespace discord_bot
{
    public class Program
    {
        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            var client = new DiscordSocketClient();
            var commands = new CommandService();
            var handler = new CommandHandler(client, commands);

            client.Log += Log;
            var token = Environment.GetEnvironmentVariable("discordBot");

            await handler.InstallCommandsAsync();
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}