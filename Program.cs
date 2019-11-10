namespace MyBot1
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
    
    class CoffeBot:SlackBot
    {
        #region constructors
        public CoffeBot():base("xoxb-816926727939-830491017047-YfyCgrTvjwWGmTYiyuLTLxvZ")
        {
            _bot.RespondsTo("kawa").With("ze śmietanką czy bez").With("espresso raz").With("zapraszam na filiżankę");
            _bot.Responders.Add(new SimpleResponder());
        }
        #endregion
    }
    class SimpleResponder:IResponder
    {
        #region impolementation IResponder
        public bool CanRespond(ResponseContext context)
        {
            return context.Message.Text.ToLower().Contains("hello");
        }
        public BotMessage GetResponse(ResponseContext context)
        {
            BotMessage response = new BotMessage();
            response.Text = $"Hello {context.Message.User.FormattedUserID}";
            return response;
        }        
        #endregion
    }
    class DocxReader
    {
        /*
            Document document = new Document();
            document.LoadFromFile(filepath);
            System.Diagnostics.Process.Start(filepath); 

            https://sourceforge.net/p/word-reader/wiki/Home/
            TextExtractor extractor = new TextExtractor(PathToWordDocument);
            string text = extractor.ExtractText(); //The string 'text' is now loaded with the text from the Word Document
        */
        //docx: https://github.com/xceedsoftware/docx
        //Pliki Microsoft Office można odczytywać przez Interop, a pliki Office> 2007 również przez Open XML:
        //Interop : http://blogs.techrepublic.com/howdoi/?p=190
        //Open XML : http://msdn.microsoft.com/en-us/library/bb656295(office.12).aspx
    }
    class SlackBot
    {
        private SlackBot(){}
        public SlackBot(string slackKey)
        {
            _slackKey = slackKey;
            Console.Write(".");
            _bot = new Bot();
            _bot.Connect(_slackKey);
            _bot.ConnectionStatusChanged += ConnectToSlackIfDisconnected;
            Console.Write(".");
        }
        protected Bot _bot;
        private string _slackKey;
        //private readonly ILog _log = LogManager.GetCurrentClassLogger();
        private void ConnectToSlackIfDisconnected(bool isConnected)
        {
            if (!isConnected)
            {
                Console.Write(",");
                /*Task.Factory.StartNew(
                    async () =>
                {
                while (!_bot.IsConnected)
                {
                    try
                    {
                    //_log.Info("Trying to connect to Slack...");
                    await _bot.Connect(_slackKey);
                    Console.Write(",");
                    }
                    catch (Exception exception)
                    {
                    //_log.Error(exception.InnerException?.Message ?? exception.Message);
                    Thread.Sleep(TimeSpan.FromSeconds(10));
                    }
                }
                });*/
            }
        }        
    }
}
