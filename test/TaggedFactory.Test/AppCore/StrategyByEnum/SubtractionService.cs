namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public class SubtractionService : SampleStrategyServiceBase, ISampleStrategyService
{
    public override IEnumerable<StrategiesEnum> StrategyType => new StrategiesEnum[1] { StrategiesEnum.Subtraction };

    public override long Apply(int a, int b) => a - b;

}
