using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
   public interface IContinent
    {
        Herbivore CreateHerbivore();
        Carnivore CreateCarnivore();
    }
}
