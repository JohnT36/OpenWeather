using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;


namespace OpenWeather
{
    public class WeatherForecast
    {
     
        public HttpClient _client { get; set; }
        private string apiKey = "";
        private string city_Name;

        public WeatherForecast()
        {
            this._client = new HttpClient();
            
        }


        public void GetWeather()
        {
            while (true)
            {
                
                
                Console.WriteLine("Please enter the city");
                city_Name = Console.ReadLine();
                var wetherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city_Name}&units=imperial&appid={apiKey}";

                var response = _client.GetStringAsync(wetherURL).Result;//basically pinging and sending response back to us.
                var weatherResponse = JObject.Parse(response).GetValue("weather").ToString();
                var tempResponse = JObject.Parse(response).GetValue("main").ToString();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(weatherResponse);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(tempResponse);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Would you like to lookup another city? Yes or No.");

                var cont = Console.ReadLine().Trim().ToLower();
                
                
                    
                if (cont == "no")
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Thank you for stopping by!");
                    Console.WriteLine("Press any key to exit..");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.ReadKey();
                    break;
                }
                if (cont != "yes")
                {
                    Console.WriteLine("I didnt quite catch that!");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Would you like to lookup another city? Yes or No.");
                    cont = Console.ReadLine().Trim().ToLower();
                }
                Console.Clear();
            }
        }
    }
}
