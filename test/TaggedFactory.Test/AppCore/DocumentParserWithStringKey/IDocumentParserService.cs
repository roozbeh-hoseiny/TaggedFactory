using TaggedFactory.Abstraction;

namespace TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

public interface IDocumentParserService : ITaggedService<string>
{
    string DocumentType { get; }

    string Test();
}
