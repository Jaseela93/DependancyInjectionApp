namespace DependancyInjection.Logic;

public class DemoLogic : IDemoLogic
{
    public int value1 { get; private set; }
    public int value2 { get; private set; }

    private readonly ILogger<DemoLogic> _logger;

    public DemoLogic(ILogger<DemoLogic> logger)
    {
        value1 = Random.Shared.Next(minValue: 1, maxValue: 1001);
        value2 = Random.Shared.Next(minValue: 1, maxValue: 1001);
        _logger = logger;
    }
}
