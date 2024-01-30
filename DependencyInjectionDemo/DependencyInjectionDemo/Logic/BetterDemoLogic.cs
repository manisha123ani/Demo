namespace DependencyInjectionDemo.Logic;

public class BetterDemoLogic
{
    public int Value1 { get; private set; }
    public int Value2 { get; private set; }

    public BetterDemoLogic()
    {
        Value1 = Random.Shared.Next(minValue: 1, maxValue: 1001);
        Value2 = Random.Shared.Next(minValue: 1, maxValue: 1001);
    }
}
