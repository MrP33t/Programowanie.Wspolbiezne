using Programowanie.Wspolbiezne.Zad3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad3.Classes
{
    internal class Component1 : BaseComponent
    {
        public Component1(IMediator mediator) : base(mediator)
        {
        }

        public void DoA()
        {
            Console.WriteLine("Component1 does DoA");
            _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component1 does DoB");
            _mediator.Notify(this, "B");
        }
    }
}
