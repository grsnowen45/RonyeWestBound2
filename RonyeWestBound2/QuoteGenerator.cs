using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace RonyeWestBound2
{
    public class QuoteGenerator
    {
        
        
            public static void KanyeQuote()
            {
                var client = new HttpClient();

                var kanyeURL = "https://api.kanye.rest";

                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"-------------");
            Console.WriteLine($"Kanye said: {kanyeQuote}");
            Console.WriteLine($"-------------");


            }
            public static void RonQuote()
            {
                var client = new HttpClient();

                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

                var ronResponse = client.GetStringAsync(ronURL).Result;

                var ronQuote =JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"-------------");
            Console.WriteLine($"Then Ron said: {ronQuote}");
            Console.WriteLine($"-------------");
            }

        public static void KanyeFinalQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeFinalResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeFinalResponse).GetValue("quote").ToString();

            Console.WriteLine($"-------------");
            Console.WriteLine($"So Kanye flipped out, called out taylor swift, and yelled: {kanyeQuote}");
            Console.WriteLine($"-------------");


        }

    }
}
