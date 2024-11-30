using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    internal class BlueColor : IColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Im blue dabadee");
        }
    }
}
