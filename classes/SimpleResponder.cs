namespace MyBot
{
    using MargieBot;
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
}