using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;


namespace OpenWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            Console.WriteLine("Please enter API key");
            var apiKey = Console.ReadLine();
            while(true)
            {
                Console.WriteLine("Please enter the city");
                var city_Name = Console.ReadLine();
                var wetherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_Name}&units=imperial&appid={apiKey}";

                var response = client.GetStringAsync(wetherURL).Result;//basically pinging and sending response back to us.
                
                var formattedResponse = JObject.Parse(response).GetValue("main").ToString();
                Console.WriteLine(formattedResponse);

                Console.WriteLine("Would you like to lookup another city? Yes or No.");

                var cont =Console.ReadLine().ToLower();

                if ( cont == "no")
                {
                    break;
                }
                
                

            }

        }
    }
}
