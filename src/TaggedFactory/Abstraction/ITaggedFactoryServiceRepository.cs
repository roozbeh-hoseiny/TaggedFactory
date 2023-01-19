namespace TaggedFactory.Abstraction;

/// <summary>
/// Defines a list of registered service types which can be retrieved by <see cref="ITaggedFactoryService{TTagType,TServiceType}" 
/// </summary>
/// <typeparam name="TTagType"></typeparam>
public interface ITaggedFactoryServiceRepository<TTagType>
{
    /// <summary>
    /// Adds an entry to collection
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    bool Add(TTagType tag, Type type);

    /// <summary>
    /// Get type of registered service by its tag
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    Type Get(TTagType tag);

    /// <summary>
    /// generates a tag key for collection
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    string GetKey(TTagType tag);
}