using TaggedFactory.Abstraction;

namespace TaggedFactory.Test.AppCore.StrategyByEnum;

public sealed class SampleStrategyServiceRepository : TaggedFactoryServiceRepositoryBase<IEnumerable<StrategiesEnum>>, ITaggedFactoryServiceRepository<IEnumerable<StrategiesEnum>>
{
    public override string GetKey(IEnumerable<StrategiesEnum> tag) => string.Join("_", tag.Select(x => x.ToString()));
    
}
