using Programowanie.Wspolbiezne.Zad2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad2.Classes.Windows
{
    internal class WindowsProduct1 : IProduct1
    {
        public string GetName()
        {
            return "Product1 for Windows";
        }
    }
}
