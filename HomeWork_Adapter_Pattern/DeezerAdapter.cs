using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Adapter_Pattern
{
     class DeezerAdapter: IApiUrl
    {
        private readonly Dezer adaptee;
        public DeezerAdapter(Dezer adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Url()
        {
            string url = "https://api.deezer.com/";
            Console.WriteLine("Введите title:");
            string title = Console.ReadLine();
            Console.WriteLine("Введите page:");
            int.TryParse(Console.ReadLine(), out int page);
            Console.WriteLine("Введите limit:");
            int.TryParse(Console.ReadLine(), out int limit);
            adaptee.DeezerUrl(url, title, page, limit);
            Console.WriteLine();
        }
    }
}
