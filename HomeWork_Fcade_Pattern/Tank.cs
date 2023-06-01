using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Fcade_Pattern
{
    public class Tank
    {
        static private Random random = new Random();

        public int level { get; private set; }

        public void OpenValve()
        {
            Console.WriteLine("Топлива подаётся в двигатель");
        }

        public void CloseValve() 
        {
            Console.WriteLine("Топлива не подаётся в двигатель");
        }

        public void PumpFuel()
        {
            level = random.Next(0, 50);

                if (level == 0)
                {
                    Console.WriteLine("Заправте машину");
                }
                else if (level < 9)
                {
                    Console.WriteLine("Топливо заканчивается");
                }
                else if (level >= 10 && level <= 30)
                {
                    Console.WriteLine("1/2");
                }
                else if (level >= 40)
                {
                    Console.WriteLine("Полный бак");
                }
            Console.WriteLine($"Топлива в баке: {level}");
        }
    }
}
