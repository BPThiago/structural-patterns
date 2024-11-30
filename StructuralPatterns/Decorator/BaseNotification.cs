﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    internal class BaseNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
