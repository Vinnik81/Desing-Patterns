﻿using System;
using System.Collections.Generic;

namespace Factory_Method_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Wizzard> wizzards = new List<Wizzard>();
            List<IWizzardFactory> wizzardCreartors = new List<IWizzardFactory>();

            wizzardCreartors.Add(new HealerFactory());
            wizzardCreartors.Add(new WarlockFactory());

            for (int i = 0; i < 10; i++)
            {
                int randCreatorIndex = rand.Next(0, wizzardCreartors.Count);
                Wizzard wizard = wizzardCreartors[randCreatorIndex].Create();
                wizzards.Add(wizard);
            }

            foreach (var creartor in wizzards)
            {
                Console.WriteLine($"Created {creartor.GetType().Name}");
            }

            /*IWizzardCreartor[] creartors = new IWizzardCreartor[2];
            creartors[0] = new HealerCreator();
            creartors[1] = new WarlockCreator();

            foreach (IWizzardCreartor creartor in creartors)
            {
                Wizzard wizzard = creartor.Create();
                Console.WriteLine($"Created {wizzard.GetType().Name}");
                wizzard.Info();
            }*/
        }
    }
}
