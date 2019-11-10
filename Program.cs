namespace MyBot1
{
    using System;
    using MargieBot;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("...");
            Bot mybot = new Bot();
            mybot.Connect("xoxb-816926727939-816929558451-KjCljodsuz1SzHMwMIlGVE9g");
            Console.WriteLine("...");
            Console.Read();
        }
    }
}
