// See https://aka.ms/new-console-template for more information
using HomeWork_Fcade_Pattern;

Car bmv = new Car();
Console.WriteLine("Заведите машину: напечатайте слово 'start'");
string start = Console.ReadLine();
if (start == "start") bmv.Start();
Console.WriteLine("Заглушите машину: нажмите любую клавишу.");
Console.ReadLine();
bmv.Stop();