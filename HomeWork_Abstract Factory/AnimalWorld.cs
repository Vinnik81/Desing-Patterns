using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_Abstract_Factory
{
   public class AnimalWorld
    {
        private Herbivore herbivoreAnimal;
        private Carnivore carnivoreAnimal;

        public int WildebeestCount { get; set; } = 10;
        public int BisonCount { get; set; } = 10;
        public int LionCount { get; set; } = 5;
        public int WolfCount { get; set; } = 8;
        public int ElkCount { get; set; } = 2;
        public int TigerCount { get; set; } = 1;

        public Herbivore CreateHerbivoreAnimal(IContinent continent)
        {
            herbivoreAnimal = continent.CreateHerbivore();
            return herbivoreAnimal;
        }

        public Carnivore CreateCarnivoreAnimal(IContinent continent)
        {
            carnivoreAnimal = continent.CreateCarnivore();
            return carnivoreAnimal;
        }

        //public AnimalWorld(IContinent continent)
        //{
        //    herbivoreAnimal = continent.CreateHerbivore();
        //    carnivoreAnimal = continent.CreateCarnivore();
        //}

        List<Herbivore> wildebeest;
        List<Herbivore> bison;
        List<Herbivore> elk;
        List<Carnivore> lion;
        List<Carnivore> wolf;
        List<Carnivore> tiger;

        public void CreateAnimals()
        {
            wildebeest = new List<Herbivore>(WildebeestCount);
            bison = new List<Herbivore>(BisonCount);
            elk = new List<Herbivore>(ElkCount);
            lion = new List<Carnivore>(LionCount);
            wolf = new List<Carnivore>(WolfCount);
            tiger = new List<Carnivore>(TigerCount);
            for (int i = 0; i < WildebeestCount; i++) wildebeest.Add(new Wildebeest());
            for (int i = 0; i < BisonCount; i++) bison.Add(new Bison());
            for (int i = 0; i < ElkCount; i++) elk.Add(new Elk());
            for (int i = 0; i < LionCount; i++) lion.Add(new Lion());
            for (int i = 0; i < WolfCount; i++) wolf.Add(new Wolf());
            for (int i = 0; i < TigerCount; i++) tiger.Add(new Tiger());
        }

        public void MealsHerbivores()
        {
            foreach (var herbivore in wildebeest) herbivore.EatGrass();
            foreach (var herbivore in bison) herbivore.EatGrass();
            foreach (var herbivore in elk) herbivore.EatGrass();
        }

        public void NutritionCarnivores()
        {
            Random rnd = new Random();

            for (int i = 0; i < LionCount; i++)
            {
                int random = rnd.Next(0, WildebeestCount);
                if (random != 0)
                {
                    lion[i].Eat(wildebeest[random - 1]);
                    if (wildebeest[random - 1].Life == false)
                    {
                        wildebeest.RemoveAt(random - 1);
                        WildebeestCount = wildebeest.Count();
                        continue;
                    }
                }
                lion[i].Power -= 10;
                if (lion[i].Power <= 0)
                {
                    lion.RemoveAt(i);
                    LionCount = lion.Count();
                }
            }

            for (int i = 0; i < WolfCount; i++)
            {
                int random = rnd.Next(0, BisonCount);
                if (random != 0)
                {
                    wolf[i].Eat(bison[random - 1]);
                    if (bison[random - 1].Life == false)
                    {
                        bison.RemoveAt(random - 1);
                        BisonCount = bison.Count();
                        continue;
                    }
                }
                wolf[i].Power -= 10;
                if (wolf[i].Power <= 0)
                {
                    wolf.RemoveAt(i);
                    WolfCount = wolf.Count();
                }
            }

            for (int i = 0; i < TigerCount; i++)
            {
                int random = rnd.Next(0, ElkCount);
                if (random != 0)
                {
                    tiger[i].Eat(elk[random - 1]);
                    if (elk[random - 1].Life == false)
                    {
                        elk.RemoveAt(random - 1);
                        ElkCount = elk.Count();
                        continue;
                    }
                }
                tiger[i].Power -= 10;
                if (tiger[i].Power <= 0)
                {
                    tiger.RemoveAt(i);
                    TigerCount = tiger.Count();
                }
            }
        }
    }
}
