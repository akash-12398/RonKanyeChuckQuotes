using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace RSwansonKWestQuotes
{   
    public class QuoteGenerator
    {
        private HttpClient _client;

        public QuoteGenerator(HttpClient client)
        {
            _client = client;
        }

          public string KanyeQuote()
          {
             var  kanyeURL = "https://api.kanye.rest";

             var KanyeResponse = _client.GetStringAsync(kanyeURL).Result;

            var KanyeQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();

            return KanyeQuote;
          }

        public string RonQuote()
        {
           var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";


            var RonResponse = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(RonResponse).ToString();
            return ronQuote;

        }

        public string ChuckQuote()
        {

            var chuckURL = "https://api.chucknorris.io/jokes/random";

            var ChuckResponse = _client.GetStringAsync(chuckURL).Result;

            var chuckQuote = JObject.Parse(ChuckResponse).GetValue("value").ToString();

            return chuckQuote;

        }
        


    }
}


