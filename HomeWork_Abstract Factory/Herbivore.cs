using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract_Factory
{
   public abstract class Herbivore
    {
       public abstract int Weight { get; set; }
       public abstract bool Life { get; set; }

       public abstract void EatGrass();
    }
}
