using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    internal class ProxyImage : IImage
    {
        private RealImage _realImage;

        public void Display()
        {
            if (_realImage == null)
            {
                Console.WriteLine("ProxyService: Criando uma instância de RealImage.");
                _realImage = new RealImage();
            }

            Console.WriteLine("ProxyService: Delegando a requisição ao RealImage.");
            _realImage.Display();
        }
    }
}
