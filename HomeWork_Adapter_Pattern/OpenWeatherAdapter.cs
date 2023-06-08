using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace HomeWork_Adapter_Pattern
{
    class OpenWeatherAdapter : IApiUrl
    {
        private readonly OpenWeather adaptee;
        public OpenWeatherAdapter(OpenWeather adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Url()
        {
            string url = "https://api.openweathermap.org/data/2.5/";
            Console.WriteLine("Введите город:");
            string cityName = Console.ReadLine();
            Console.WriteLine("Введите api:");
            string api = Console.ReadLine();
            Console.WriteLine("Введите lang:");
            string lang = Console.ReadLine();
            Console.WriteLine("Введите units:");
            string units = Console.ReadLine();
            adaptee.OpenWeatherUrl(url, cityName, api, lang, units);
            Console.WriteLine();
        }
    }
}
