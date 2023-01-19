namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public class Sum_MultiplicationService : SampleStrategyServiceBase, ISampleStrategyService
{
    public override IEnumerable<StrategiesEnum> StrategyType => new StrategiesEnum[2] { StrategiesEnum.Sum , StrategiesEnum.Multiplication };

    public override long Apply(int a, int b) => (a + b) * b;

}
