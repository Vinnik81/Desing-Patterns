using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Fcade_Pattern
{
    public class Car
    {
        private Engine engine;
        private Tank tank;

        public Car()
        {
            engine = new Engine();
            tank = new Tank();
        }

        public void Start()
        {
            tank.PumpFuel();
            engine.Start();
            tank.OpenValve();
        }

        public void Stop() 
        {
            engine.Stop();
            tank.CloseValve();
        }
    }
}
