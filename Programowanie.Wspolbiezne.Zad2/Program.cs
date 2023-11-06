// See https://aka.ms/new-console-template for more information


using Programowanie.Wspolbiezne.Zad2.Classes.OS;
using Programowanie.Wspolbiezne.Zad2.Classes.Windows;
using Programowanie.Wspolbiezne.Zad2.Interfaces;

RunProgram("Windows");
RunProgram("OS");

void RunProgram(string system)
{
    IFactory factory;
    if (system.Equals("Windows"))
    {
        Console.WriteLine("System Windows");
        factory = new WindowsFactory();
    }
    else
    {
        Console.WriteLine("System OS");
        factory = new OSFactory();
    }

    Console.WriteLine(factory.CreateProduct1().GetName());
    Console.WriteLine(factory.CreateProduct2().GetName());
}