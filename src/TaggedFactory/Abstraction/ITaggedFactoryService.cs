namespace TaggedFactory.Abstraction;

public interface ITaggedFactoryService<TTagType, TServiceType>
{
    TServiceType Create(TTagType tag);
}