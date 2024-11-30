using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    internal class DvdPlayer
    {
        public void Play(string movie)
        {
            Console.WriteLine($"Rodando filme: {movie}");
        }

        public void Stop()
        {
            Console.WriteLine("Parando filme");
        }
    }
}
