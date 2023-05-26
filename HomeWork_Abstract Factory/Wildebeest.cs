using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
   public class Wildebeest : Herbivore
    {
        public override int Weight { get; set; }
        public override bool Life { get; set; }

        public Wildebeest()
        {
            Random random = new Random();
            Weight = random.Next(60, 70);
            Life = true;
        }


        public override void EatGrass()
        {
            Weight += 10;
            Console.WriteLine("Антилопа ест траву");
        }
    }
}
