namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public class DivisionService : SampleStrategyServiceBase, ISampleStrategyService
{
    public override IEnumerable<StrategiesEnum> StrategyType => new StrategiesEnum[1] { StrategiesEnum.Division };

    public override long Apply(int a, int b) => b == 0 ? 0 :  a / b;

}
