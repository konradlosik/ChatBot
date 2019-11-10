namespace MyBot
{
    using MargieBot;
    class CoffeBot:SlackBot
    {
        #region constructors
        public CoffeBot():base("xoxb-816926727939-830491017047-SlbEXAn3f4yakRbeBHL4MRLj")
            //"xoxb-816926727939-830491017047-i3DBQ1iwXOPf6fDIuFIfrb8j")
        {
            _bot.RespondsTo("kawa").With("ze śmietanką czy bez").With("espresso raz").With("zapraszam na filiżankę");
            _bot.Responders.Add(new SimpleResponder());
            _bot.Responders.Add(new WeatherResponder("65ce176397e0db966aa0be8645d06327"));
        }
        #endregion
    }
}