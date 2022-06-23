using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;


namespace OpenWeather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var weather = new WeatherForecast();
            weather.GetWeather();
            
           
                
                

            

        }
    }
}
