using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    internal class MenuItem : IMenuComponent
    {
        private string name;

        public MenuItem(string name)
        {
            this.name = name;
        }

        public void Display(String indent)
        {
            Console.WriteLine(indent + name);
        }

        public void Add(IMenuComponent menuComponent)
        {
            throw new InvalidOperationException("Nao eh possivel adicionar a um item.");
        }
    }
}
