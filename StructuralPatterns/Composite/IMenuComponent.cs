using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    internal interface IMenuComponent
    {
        void Display(String indent);
        void Add(IMenuComponent menuComponent);
    }
}
