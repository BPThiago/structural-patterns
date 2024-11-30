namespace StructuralPatterns.Bridge
{
    internal class RedColor : IColor
    {
        public void ApplyColor()
        {
            System.Console.WriteLine("spell red");
        }
    }
}
