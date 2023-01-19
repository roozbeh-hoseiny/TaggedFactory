using TaggedFactory.Abstraction;

namespace TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

public sealed class DocumentParserServiceRepository : TaggedFactoryServiceRepositoryBase<string>, ITaggedFactoryServiceRepository<string>
{
    public override string GetKey(string tag) => tag;
}
