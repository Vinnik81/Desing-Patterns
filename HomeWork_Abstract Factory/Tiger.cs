using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    public class Tiger : Carnivore
    {
        public override int Power { get; set; }
        public override bool Life { get; set; }

        public Tiger()
        {
            Random random = new Random();
            Power = random.Next(60, 110);
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
                Console.WriteLine($"Тигр охотится на {herbivore.GetType().Name}");
            }
        }
    }
}
