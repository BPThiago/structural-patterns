using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    internal class Lights
    {
        public void On()
        {
            Console.WriteLine("Luzes ligadas");
        }

        public void Off()
        {
            Console.WriteLine("Luzes desligadas");
        }
    }
}
