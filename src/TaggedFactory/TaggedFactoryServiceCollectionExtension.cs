using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;
using TaggedFactory.Abstraction;

namespace TaggedFactory;

public static class TaggedFactoryServiceCollectionExtension
{
    public static ITaggedFactoryServiceBuilder AddTaggedFactoryService<TTagType, TServiceType, TRepository, TFactory>(
        this IServiceCollection services,
        ServiceLifetime lifetime,
        Assembly[] assemblies)
        where TRepository : class, ITaggedFactoryServiceRepository<TTagType>, new()
        where TServiceType : ITaggedService<TTagType>
        where TFactory : class, ITaggedFactoryService<TTagType, TServiceType>
    {
        var builder = new TaggedFactoryServiceBuilder(services);

        builder.Services.Scan(scan => scan
           .FromAssemblies(assemblies)
               .AddClasses(classes => classes.AssignableTo<TServiceType>(), publicOnly: false)
                   .AsSelfWithInterfaces()
                   .WithLifetime(lifetime)
        );

        builder.Services.TryAddSingleton(sp =>
        {
            var result = new TRepository();
            var registeredServices = sp.GetServices<TServiceType>();
            if (registeredServices is null) throw new Exception($"Can not find any registered service with type : \"{typeof(TServiceType)}\"");

            foreach (var registeredService in registeredServices)
                result.Add(registeredService.GetTag(), registeredService.GetType());

            return result;
        });

        builder.Services.Add(ServiceDescriptor.Describe(typeof(TFactory), typeof(TFactory), lifetime));

        return builder;
    }
    public static ITaggedFactoryServiceBuilder AddTaggedFactoryService<TTagType, TServiceType, TRepository, TFactory>(this IServiceCollection services,
        ServiceLifetime lifetime,
        Assembly assembly
    )
    where TRepository : class, ITaggedFactoryServiceRepository<TTagType>, new()
    where TServiceType : ITaggedService<TTagType>
    where TFactory : class, ITaggedFactoryService<TTagType, TServiceType>
        => services.AddTaggedFactoryService<TTagType, TServiceType, TRepository, TFactory>(lifetime, new Assembly[] { assembly });
}