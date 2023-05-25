using System;

namespace HomeWork_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IContinent africa = new Africa();
            AnimalWorld animalWorld = new AnimalWorld();
            animalWorld.CreateHerbivoreAnimal(africa);
            animalWorld.CreateCarnivoreAnimal(africa);
            animalWorld.CreateAnimals();
            animalWorld.MealsHerbivores();
            animalWorld.NutritionCarnivores();

            IContinent america = new NorthAmerica();
            animalWorld.CreateHerbivoreAnimal(america);
            animalWorld.CreateCarnivoreAnimal(america);

            Console.WriteLine($"Количество антилоп: {animalWorld.WildebeestCount}");
            Console.WriteLine($"Количество бизонов: {animalWorld.BisonCount}");
            Console.WriteLine($"Количество львов: {animalWorld.LionCount}");
            Console.WriteLine($"Количество волков: {animalWorld.WolfCount}");
        }
    }
}
