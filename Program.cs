//source https://www.spidersweb.pl/2019/05/bot-programowanie-net-core.html 
namespace MyBot
{
    using System;
    using MargieBot;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(".");
            
            new CoffeBot();

            Console.Write(".%");
            Console.Read();
        }
    }
}