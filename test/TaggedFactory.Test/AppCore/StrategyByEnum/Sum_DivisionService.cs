namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public class Sum_DivisionService : SampleStrategyServiceBase, ISampleStrategyService
{
    public override IEnumerable<StrategiesEnum> StrategyType => new StrategiesEnum[2] { StrategiesEnum.Sum, StrategiesEnum.Division };

    public override long Apply(int a, int b) => b == 0 ? a : (a + b) / b;

}
