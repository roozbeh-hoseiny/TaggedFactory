namespace TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

public sealed class ExcelParser : DocumentParserServiceBase, IDocumentParserService
{
    public override string DocumentType => "Excel";
}
