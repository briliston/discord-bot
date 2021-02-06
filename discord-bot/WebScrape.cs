using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace discord_bot
{
    public class WebScrape
    {
        static ScrapingBrowser _browser = new ScrapingBrowser();

        public static string GetMainPageLinks(string url)
        {
            var homePageLinks = new List<string>();
            var html = GetHtml(url);
            var links = html.CssSelect("div.yuRUbf > a.para");

            foreach (var link in links)
            {
                homePageLinks.Add(link.Attributes["href"].Value);
            }
            Console.WriteLine(homePageLinks[0]);
            return homePageLinks[0];
        }

        static HtmlNode GetHtml(string url)
        {
            WebPage webpage = _browser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }

    }
}
