namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public class SumService : SampleStrategyServiceBase, ISampleStrategyService
{
    public override IEnumerable<StrategiesEnum> StrategyType => new StrategiesEnum[1] { StrategiesEnum.Sum };

    public override long Apply(int a, int b) => a + b;
    
}
