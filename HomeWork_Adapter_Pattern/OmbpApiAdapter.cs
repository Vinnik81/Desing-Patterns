using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Adapter_Pattern
{
    class OmbpApiAdapter : IApiUrl
    {
        private readonly OmbApi adaptee;

        public OmbpApiAdapter(OmbApi adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Url()
        {
            string url = "https://omdbapi.com/";
            Console.WriteLine("Введите title:");
            string title = Console.ReadLine();
            Console.WriteLine("Введите api:");
            string api = Console.ReadLine();
            adaptee.OmbpiUrl(url, title, api);
            Console.WriteLine();
        }
    }
}
