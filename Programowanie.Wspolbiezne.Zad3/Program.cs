// See https://aka.ms/new-console-template for more information
using Programowanie.Wspolbiezne.Zad3.Classes;

Mediator mediator = new Mediator();
Component1 component1 = new Component1(mediator);
Component2 component2 = new Component2(mediator);

mediator.AddComponent(component1);
mediator.AddComponent(component2);

Console.WriteLine("Raise event on component1");
component1.DoA();
Console.WriteLine("Raise event on component2");
component2.DoD();