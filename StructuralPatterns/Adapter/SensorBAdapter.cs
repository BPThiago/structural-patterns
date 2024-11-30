namespace StructuralPatterns.Adapter
{
    internal class SensorBAdapter : ITemperatureSensor
    {
        private readonly SensorB sensorB = new SensorB();
        public double ReadTemperature()
        {
            return sensorB.ObtenerTemperaturaEnCentigrados();
        }
    }
}
