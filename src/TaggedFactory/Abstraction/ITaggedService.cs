namespace TaggedFactory.Abstraction;

/// <summary>
/// Defines a service which can be retrieved by <see cref="ITaggedFactoryService{TTagType,TServiceType}" />
/// </summary>
/// <typeparam name="TTagType">type of tag</typeparam>
public interface ITaggedService<TTagType>
{
    TTagType GetTag();
}