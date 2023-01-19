namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public abstract class SampleStrategyServiceBase : ISampleStrategyService
{
    public abstract IEnumerable<StrategiesEnum> StrategyType { get; }

    public IEnumerable<StrategiesEnum> GetTag() => this.StrategyType;
    

    public abstract long Apply(int a, int b);
}
