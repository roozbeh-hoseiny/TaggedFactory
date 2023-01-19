namespace TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

public abstract class DocumentParserServiceBase : IDocumentParserService
{
    public abstract string DocumentType { get; }

    public string Test() => $"I am {DocumentType}";
    public string GetTag() => DocumentType;
}
