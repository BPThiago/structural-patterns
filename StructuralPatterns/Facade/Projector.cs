using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    internal class Projector
    {
        public void On()
        {
            Console.WriteLine("Ligando projetor... O que será exibido?");
        }

        public void Off()
        {
            Console.WriteLine("Desligando projetor... volte sempre");
        }
    }
}
