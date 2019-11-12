namespace MyBot
{
    using MargieBot;
    using System;
    using System.Threading.Tasks;
    using System.Threading;
    class SlackBot
    {
        private SlackBot(){}
        public SlackBot(string slackKey)
        {
            _slackKey = slackKey;
            LogHelper.Write(".",DebugLevelEnum.trace);
            _bot = new Bot();
            _bot.ConnectionStatusChanged += ConnectToSlackIfDisconnected;
            _bot.Connect(_slackKey);
            LogHelper.Write(". stat="+_bot.IsConnected,DebugLevelEnum.trace);
        }
        protected Bot _bot;
        private string _slackKey;
        //private readonly ILog _log = LogManager.GetCurrentClassLogger();
        private void ConnectToSlackIfDisconnected(bool isConnected)
        {
            LogHelper.Write(_bot.IsConnected+",");
            if (!isConnected)
            {
                LogHelper.Write(",",DebugLevelEnum.trace);
                Task.Factory.StartNew(
                    async () =>
                {
                while (!_bot.IsConnected)
                {
                    try
                    {
                    //_log.Info("Trying to connect to Slack...");
                    await _bot.Connect(_slackKey);
                    LogHelper.Write(",",DebugLevelEnum.trace);
                    }
                    catch (Exception exception)
                    {
                    //_log.Error(exception.InnerException?.Message ?? exception.Message);
                        Thread.Sleep(TimeSpan.FromSeconds(10));
                        LogHelper.WriteLine(exception.Message,DebugLevelEnum.error);
                    }
                }
                });
            }
        }        
    }

}