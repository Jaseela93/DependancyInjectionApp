namespace DependancyInjection.Logic
{
    public class BetterDemoLogic : IDemoLogic
    {
        public int value1 { get; private set; }
        public int value2 { get; private set; }

        public BetterDemoLogic()
        {
            value1 = 25;
            value2 = 50;
        }

    }
}
