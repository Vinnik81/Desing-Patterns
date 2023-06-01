using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Fcade_Pattern
{
    public class Engine
    {

        public void Start()
        {
            Console.WriteLine("Двигатель запущен");
        }

        public void Stop() 
        {
            Console.WriteLine("Двигатель заглушен");
        }
    }
}
