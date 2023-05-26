using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
   public class NorthAmerica : IContinent
    {
        public Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
