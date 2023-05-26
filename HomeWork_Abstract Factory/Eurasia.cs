using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    public class Eurasia : IContinent
    {
        public Herbivore CreateHerbivore()
        {
            return new Elk();
        }

        public Carnivore CreateCarnivore()
        {
            return new Tiger();
        }
    }
}
