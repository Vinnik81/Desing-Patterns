using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Adapter_Pattern
{
   public class OpenWeather
    {
        public void OpenWeatherUrl(string baseUrl, string cityName, string apiKey, string lang, string units)
        {
            Console.WriteLine("OpenWeather:");
            Console.Write(baseUrl);
            Console.Write($"weather?q={cityName}");
            Console.Write($"&aapid={apiKey}&lang={lang}&units={units}");
        }
    }
}
