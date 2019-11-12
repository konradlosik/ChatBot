//source https://www.spidersweb.pl/2019/05/bot-programowanie-net-core.html 
namespace MyBot
{
    using System;
    using MargieBot;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example using html parser and bot...");
            LogHelper.Write(".");
            new HtmlParser();
            new CoffeBot();
            LogHelper.Write(".&");
            Console.Read(); 
        }
    }
}