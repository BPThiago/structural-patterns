using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    internal class TreeType
    {
        public string Texture { get; }

        public TreeType(string texture)
        {
           Texture = texture;
        }
    }
}
