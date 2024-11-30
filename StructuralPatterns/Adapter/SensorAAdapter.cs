namespace StructuralPatterns.Adapter
{
    internal class SensorAAdapter : ITemperatureSensor
    {
        private readonly SensorA sensorA = new SensorA();
        public double ReadTemperature()
        {
            return sensorA.GetTemperatureInCelsius();
        }
    }
}
