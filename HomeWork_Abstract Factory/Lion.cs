using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    class Lion : Carnivore
    {
        public override int Power { get; set; }
        public override bool Life { get; set; }

        public Lion()
        {
            Random random = new Random();
            Power = random.Next(70, 90);
            Life = true;
        }


        public override void Eat(Herbivore herbivore)
        {
            if (herbivore != null)
            {
                if (herbivore.Weight <= Power)
                {
                    herbivore.Life = false;
                    Power += 10;
                }
                else
                {
                    Power -= 10;
                }
                //Console.WriteLine($"Лев охотится на {herbivore.GetType().Name}");
            }
        }
    }
}
