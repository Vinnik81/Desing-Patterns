using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    public abstract class Carnivore
    {
        public abstract int Power { get; set; }
        public abstract bool Life { get; set; }

        public abstract void Eat(Herbivore herbivore);
    }
}
