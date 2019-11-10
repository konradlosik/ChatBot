namespace MyBot
{
    using MargieBot;
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
}