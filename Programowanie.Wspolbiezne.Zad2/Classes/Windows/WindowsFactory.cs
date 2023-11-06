using Programowanie.Wspolbiezne.Zad2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad2.Classes.Windows
{
    internal class WindowsFactory : IFactory
    {
        public IProduct1 CreateProduct1()
        {
            return new WindowsProduct1();
        }

        public IProduct2 CreateProduct2()
        {
            return new WindowsProduct2();
        }
    }
}
