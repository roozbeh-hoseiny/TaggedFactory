using TaggedFactory.Abstraction;

namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public interface ISampleStrategyService : ITaggedService<IEnumerable<StrategiesEnum>>
{
    IEnumerable<StrategiesEnum> StrategyType { get; }

    long Apply(int a, int b);
}
