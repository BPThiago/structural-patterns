using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    internal class SensorCAdapter : ITemperatureSensor
    {
        private readonly SensorC sensorC = new SensorC();
        public double ReadTemperature()
        {
            return sensorC.FetchTempC();
        }
    }
}
