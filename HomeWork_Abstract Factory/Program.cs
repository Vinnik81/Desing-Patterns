using System;

namespace HomeWork_Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Press Enter to restart the program...");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    IContinent africa = new Africa();
                    AnimalWorld animalWorld = new AnimalWorld();
                    animalWorld.CreateAnimals();
                    animalWorld.MealsHerbivores();
                    animalWorld.NutritionCarnivores();

                    animalWorld.CreateHerbivoreAnimal(africa);
                    animalWorld.CreateCarnivoreAnimal(africa);

                    IContinent america = new NorthAmerica();
                    animalWorld.CreateHerbivoreAnimal(america);
                    animalWorld.CreateCarnivoreAnimal(america);

                    IContinent eurasia = new Eurasia();
                    animalWorld.CreateHerbivoreAnimal(eurasia);
                    animalWorld.CreateCarnivoreAnimal(eurasia);

                    Console.WriteLine($"Количество антилоп: {animalWorld.WildebeestCount}");
                    Console.WriteLine($"Количество бизонов: {animalWorld.BisonCount}");
                    Console.WriteLine($"Количество лосей: {animalWorld.ElkCount}");
                    Console.WriteLine($"Количество львов: {animalWorld.LionCount}");
                    Console.WriteLine($"Количество волков: {animalWorld.WolfCount}");
                    Console.WriteLine($"Количество тигров: {animalWorld.TigerCount}");

                    Console.WriteLine("\nДля выхода нажмите ESC");
                }
                else if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
            while (true);
        }
    }
}
