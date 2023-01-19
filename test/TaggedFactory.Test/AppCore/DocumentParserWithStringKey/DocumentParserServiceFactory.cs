using TaggedFactory.Abstraction;

namespace TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

public sealed class DocumentParserServiceFactory : TaggedFactoryServiceBase<string, IDocumentParserService>, ITaggedFactoryService<string, IDocumentParserService>
{
    public DocumentParserServiceFactory(IServiceProvider serviceProvider, DocumentParserServiceRepository repo) : base(serviceProvider, repo) { }
}
