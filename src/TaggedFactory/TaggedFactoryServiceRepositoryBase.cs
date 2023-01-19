using TaggedFactory.Abstraction;

namespace TaggedFactory;

public abstract class TaggedFactoryServiceRepositoryBase<TTagType> : ITaggedFactoryServiceRepository<TTagType>
{
    private Dictionary<string, Type> _repository = new(StringComparer.InvariantCultureIgnoreCase);

    public virtual bool Add(TTagType tag, Type type) => _repository.TryAdd(GetKey(tag), type);

    public Type Get(TTagType tag)
    {

        var key = GetKey(tag);
        return _repository.TryGetValue(GetKey(tag), out var result) ? result : throw new KeyNotFoundException($"key \"{key}\" is not exists.");
    }

    public abstract string GetKey(TTagType tag);
}