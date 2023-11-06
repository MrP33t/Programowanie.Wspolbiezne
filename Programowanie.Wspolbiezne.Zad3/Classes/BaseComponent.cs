using Programowanie.Wspolbiezne.Zad3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad3.Classes
{
    internal class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
