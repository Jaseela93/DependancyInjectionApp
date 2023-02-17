namespace DependancyInjection.Logic
{
    public class DemoLogic
    {
        public int value1 { get; private set; }
        public int value2 { get; private set; }

        public DemoLogic()
        {
            value1 = Random.Shared.Next(minValue:1,maxValue:1001);
            value2 = Random.Shared.Next(minValue: 1, maxValue: 1001);
        }
    }
}
