using Microsoft.Extensions.DependencyInjection;
using TaggedFactory.Abstraction;

namespace TaggedFactory;

public abstract class TaggedFactoryServiceBase<TTagType, TServiceType>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ITaggedFactoryServiceRepository<TTagType> _repo;

    public TaggedFactoryServiceBase(IServiceProvider serviceProvider, ITaggedFactoryServiceRepository<TTagType> repo)
    {
        _serviceProvider = serviceProvider;
        _repo = repo;
    }

    public TServiceType Create(TTagType tag)
    {
        var serviceType = _repo.Get(tag);
        return (TServiceType)_serviceProvider.GetRequiredService(serviceType);
    }
}