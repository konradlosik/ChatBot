namespace MyBot
{
    using MargieBot;
    using System;
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