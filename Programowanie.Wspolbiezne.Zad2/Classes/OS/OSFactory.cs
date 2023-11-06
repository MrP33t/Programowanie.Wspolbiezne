using Programowanie.Wspolbiezne.Zad2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad2.Classes.OS
{
    internal class OSFactory : IFactory
    {
        public IProduct1 CreateProduct1()
        {
            return new OSProduct1();
        }

        public IProduct2 CreateProduct2()
        {
            return new OSProduct2();
        }
    }
}
