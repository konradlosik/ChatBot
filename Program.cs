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
            //todo: ResponseContext

            //Bot myBot = new Bot();
            //myBot.Connect("xoxb-816926727939-830491017047-YfyCgrTvjwWGmTYiyuLTLxvZ");//xoxb-816926727939-816929558451-KjCljodsuz1SzHMwMIlGVE9g");
            //myBot.RespondsTo("kawa").With("zapraszam na filizanke");       //myBot.RespondsTo("Heya").With("Heya, amigo!");
            
            new CoffeBot();

            Console.Write(".#");
            Console.Read();
        }
    }
    

}