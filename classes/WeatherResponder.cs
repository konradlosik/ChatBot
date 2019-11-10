namespace MyBot
{
    using System;
    using MargieBot;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;
    class WeatherResponder:IResponder
    {
        private string _apiKey {get;set;}
        #region Constructors
        private WeatherResponder(){}
        public WeatherResponder(string apiKey)
        {
            _apiKey=apiKey;
        }
        #endregion
        #region Implement IResponder
        public bool CanRespond(ResponseContext context)
        {
            return context.Message.Text.ToLower().Contains("pogoda");
        }
        public BotMessage GetResponse(ResponseContext context)
        {
            BotMessage response = new BotMessage();
            string city = context.Message.Text.Replace("pogoda ", "");
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&mode=json&units=metric&APPID={_apiKey}";
            response.Text = "Szukales pogody w miescie: " + city;
            string pogoda = String.Empty;
            using (HttpClient client = new HttpClient())
            {
                string json = RetrieveJsonAsync(url, client).Result;
                dynamic jsonData = JObject.Parse(json);
                pogoda = $"Temperatura w tym mieście to {jsonData.main.temp} stopni Celsjusza";
            }
            response.Text = response.Text + Environment.NewLine + pogoda;
            return response;
        }
        #endregion
        private async Task<string> RetrieveJsonAsync(string url, HttpClient client)
        {
            string result = await client.GetStringAsync(url);
            return result;
        }        
    }
}
/* http://api.openweathermap.org/data/2.5/weather?q=Szczecin&mode=json&units=metric&APPID=65ce176397e0db966aa0be8645d06327 
http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=65ce176397e0db966aa0be8645d06327 
http://api.openweathermap.org/data/2.5/weather?q=Szczecin&mode=json&units=metric&APPID=a068ce0ad40a322b322ed0edd8ed66be 
*/