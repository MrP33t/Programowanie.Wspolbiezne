using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad1
{
    internal class Singleton
    {
        private static Singleton? instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
                Console.WriteLine("Created singleton");
            }
            else
            {
                Console.WriteLine("Singleton already exists!");
            }
            return instance;
        }

        public void StartCounting()
        {
            new Thread(Count).Start();
        }
        private void Count()
        {
            for (int i = 0; i < 100; i++) // 10000+(on my computer) with no sleep on thread shows that they are executed at the same time
            {
                Console.WriteLine(i);
                Thread.Sleep(1); //Needed to show that they are executed in parralel if count is less than 10000
            }
        }
    }
}
