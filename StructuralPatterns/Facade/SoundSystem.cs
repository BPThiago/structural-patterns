using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    internal class SoundSystem
    {
        public void On()
        {
            Console.WriteLine("THX sound effect.mp3");
        }

        public void Off()
        {
            Console.WriteLine("... (silêncio)");
        }
    }
}
