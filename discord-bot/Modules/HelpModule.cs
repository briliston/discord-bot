using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;
using Discord.Commands;
using discord_bot;
using System.Collections.Generic;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace discord_bot.Modules.HelpModule
{
    public class HelpModule : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        [Summary("Helps provide answers to your questions")]
        public async Task HelpAsync([Remainder][Summary("The question to be answered")] string question)
        {
            var url = "https://www.google.com/search?q=" + question.Replace(" ","+") + "&rlz=1C1CHBF_enUS863US863&oq=how+to+&aqs=chrome.1.69i59l3j69i57j69i59j0l3.2757j0j15&sourceid=chrome&ie=UTF-8";
            //var link = WebScrape.GetMainPageLinks(url);
            Task.Delay(1000).Wait();
            await ReplyAsync("God damn you're lazy... Fine. I guess I'll google that for you.");
            Task.Delay(2000).Wait();
            await ReplyAsync($"{url}");
        }
    }
}
