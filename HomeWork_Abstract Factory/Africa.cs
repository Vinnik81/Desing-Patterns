using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
    class Africa : IContinent
    {

        public Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
