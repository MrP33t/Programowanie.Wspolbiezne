// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

for (int i=0; i<10; i++)
{
    new Thread(() => Count()).Start();
}

void Count()
{
    int x = 0;
    while(true) {
        Console.WriteLine(x++);
        //Thread.Sleep(1000);
    }
}