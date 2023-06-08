using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Adapter_Pattern
{
    public class Dezer
    {
        public void DeezerUrl(string baseUrl, string title, int index, int limit)
        {
            Console.WriteLine("Deezer:");
            Console.Write(baseUrl);
            Console.Write($"searche?q={title}&index={index}&limit={limit}");
        }
    }
}
