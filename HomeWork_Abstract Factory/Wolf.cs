using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    class Wolf : Carnivore
    {
        public override int Power { get; set; }
        public override bool Life { get; set; }

        public Wolf()
        {
            Random random = new Random();
            Power = random.Next(50, 80);
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
                //Console.WriteLine($"Волк охотится на {herbivore.GetType().Name}");
            }
        }
    }
}