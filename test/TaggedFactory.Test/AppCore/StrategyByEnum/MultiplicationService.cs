namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public class MultiplicationService : SampleStrategyServiceBase, ISampleStrategyService
{
    public override IEnumerable<StrategiesEnum> StrategyType => new StrategiesEnum[1] { StrategiesEnum.Multiplication };

    public override long Apply(int a, int b) => a * b;

}
