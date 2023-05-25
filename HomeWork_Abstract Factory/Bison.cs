using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    class Bison : Herbivore
    {
       public override int Weight { get; set; }
       public override bool Life { get; set; }

        public Bison()
        {
            Random random = new Random();
            Weight = random.Next(40, 200);
            Life = true;
        }



        public override void EatGrass()
        {
            Weight += 10;
            //Console.WriteLine("Бизон ест траву");
        }
    }
}
