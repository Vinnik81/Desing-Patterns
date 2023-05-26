using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    public class Elk : Herbivore
    {
        public override int Weight { get; set; }
        public override bool Life { get; set; }

        public Elk()
        {
            Random random = new Random();
            Weight = random.Next(60, 120);
            Life = true;
        }

        public override void EatGrass()
        {
            Weight += 10;
            Console.WriteLine("Лось ест траву");
        }
    }
}
