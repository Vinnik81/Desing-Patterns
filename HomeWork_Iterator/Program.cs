using System;
using System.Collections.Generic;

namespace HomeWork_Iterator
{

    class Program
    {
        static void Main(string[] args)
        {
            
            var collection = new WordsCollection();
            collection.AddItem("Первый");
            collection.AddItem("Второй");
            collection.AddItem("Третий");

            Console.WriteLine("Прямой обход:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nОбратный обход:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}