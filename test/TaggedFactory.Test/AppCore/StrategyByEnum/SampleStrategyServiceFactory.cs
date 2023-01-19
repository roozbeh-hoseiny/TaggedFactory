using TaggedFactory.Abstraction;

namespace TaggedFactory.Test.AppCore.StrategyByEnum;
public sealed class SampleStrategyServiceFactory : TaggedFactoryServiceBase<IEnumerable<StrategiesEnum>, ISampleStrategyService>, ITaggedFactoryService<IEnumerable<StrategiesEnum>, ISampleStrategyService>
{
    public SampleStrategyServiceFactory(IServiceProvider serviceProvider, SampleStrategyServiceRepository repo) : base(serviceProvider, repo){ }
}
