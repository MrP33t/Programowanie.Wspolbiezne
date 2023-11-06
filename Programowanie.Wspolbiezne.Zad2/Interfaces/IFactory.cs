using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad2.Interfaces
{
    internal interface IFactory
    {
        IProduct1 CreateProduct1();
        IProduct2 CreateProduct2();
    }
}
