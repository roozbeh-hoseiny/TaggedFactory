namespace TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

public sealed class PdfParser : DocumentParserServiceBase, IDocumentParserService
{
    public override string DocumentType => "Pdf";
}
