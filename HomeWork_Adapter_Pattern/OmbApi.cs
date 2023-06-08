using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Adapter_Pattern
{
    public class OmbApi
    {
        public void OmbpiUrl(string baseUrl, string title, string apiKey)
        {
            Console.WriteLine("Ombp:");
            Console.Write(baseUrl);
            Console.Write($"{title}/");
            Console.Write(apiKey);
        }
    }
}
