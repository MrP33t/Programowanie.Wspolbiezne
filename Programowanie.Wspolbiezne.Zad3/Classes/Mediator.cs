using Programowanie.Wspolbiezne.Zad3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie.Wspolbiezne.Zad3.Classes
{
    internal class Mediator : IMediator
    {
        private List<object> _components;

        public Mediator()
        {
            _components = new List<object>();
        }

        public void AddComponent(object component)
        {
            _components.Add(component);
        }

        public void Notify(object sender, string arg)
        {
            if (arg == "A")
            {
                var listOfComponents = _components.Where(x => x is Component2);
                foreach (Component2 component in listOfComponents)
                {
                    component.DoC();
                }
            }
            if (arg == "D")
            {
                var listOfComponents1 = _components.Where(x => x is Component1);
                foreach (Component1 component in listOfComponents1)
                {
                    component.DoB();
                }
                var listOfComponents2 = _components.Where(x => x is Component2);
                foreach (Component2 component in listOfComponents2)
                {
                    component.DoC();
                }
            }
        }
    }
}
