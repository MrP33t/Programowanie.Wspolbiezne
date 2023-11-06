// See https://aka.ms/new-console-template for more information
using Programowanie.Wspolbiezne.Zad1;

Console.WriteLine("Creating first singleton");
Singleton singleton = Singleton.GetInstance();
Console.WriteLine("Creating second singleton");
Singleton singleton2 = Singleton.GetInstance();
Console.WriteLine("Starting counting first time");
singleton.StartCounting();
Console.WriteLine("Starting counting second time");
singleton.StartCounting();