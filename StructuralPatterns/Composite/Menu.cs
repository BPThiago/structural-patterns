using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    internal class Menu : IMenuComponent
    {
        private string name;
        private List<IMenuComponent> children = new List<IMenuComponent>();

        public Menu(string name)
        {
            this.name = name;
        }

        public void Display(String indent)
        {
            Console.WriteLine(indent + name);
            foreach (var child in children)
            {
                child.Display(indent + "  ");
            }
        }

        public void Add(IMenuComponent menuComponent)
        {
            children.Add(menuComponent);
        }
    }
}
