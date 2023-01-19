namespace TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

public sealed class WordParser : DocumentParserServiceBase, IDocumentParserService
{
    public override string DocumentType => "Word";
}
