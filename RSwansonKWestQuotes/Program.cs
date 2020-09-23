using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
namespace RSwansonKWestQuotes
{
    class Program
    {
        static void Main(string[] args)
        {

            var client = new HttpClient();
            var quote = new QuoteGenerator(client);


            for (int i = 0; i < 5; i++)






             Console.WriteLine($"Kanye: {quote.KanyeQuote()}");

            Console.WriteLine($"RonQuote: {quote.RonQuote()}");

            Console.WriteLine($"ChuckQuote: {quote.ChuckQuote()}");





            
        }

    }



       
}
