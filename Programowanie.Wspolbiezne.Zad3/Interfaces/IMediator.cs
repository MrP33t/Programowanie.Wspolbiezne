using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad3.Interfaces
{
    internal interface IMediator
    {
        void Notify(object sender, string arg);
    }
}
