using Microsoft.Extensions.DependencyInjection;

namespace TaggedFactory.Abstraction;

public interface ITaggedFactoryServiceBuilder
{
    IServiceCollection Services { get; }
}