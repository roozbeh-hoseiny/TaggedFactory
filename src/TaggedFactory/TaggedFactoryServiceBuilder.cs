using Microsoft.Extensions.DependencyInjection;
using TaggedFactory.Abstraction;

namespace TaggedFactory;

public class TaggedFactoryServiceBuilder : ITaggedFactoryServiceBuilder
{
    public IServiceCollection Services { get; }

    public TaggedFactoryServiceBuilder(IServiceCollection services)
    {
        Services = services;
    }

}