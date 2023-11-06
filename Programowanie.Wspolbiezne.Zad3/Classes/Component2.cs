using Programowanie.Wspolbiezne.Zad3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad3.Classes
{
    internal class Component2 : BaseComponent
    {
        public Component2(IMediator mediator) : base(mediator)
        {
        }

        public void DoC()
        {
            Console.WriteLine("Component2 does DoC");
            _mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component2 does DoD");
            _mediator.Notify(this, "D");
        }
    }
}
