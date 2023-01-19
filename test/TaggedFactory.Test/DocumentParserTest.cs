using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TaggedFactory.Test.AppCore.DocumentParserWithStringKey;

namespace TaggedFactory.Test;

public class TaggedFactoryTest
{
    IServiceProvider _serviceProvider;
    public TaggedFactoryTest()
    {
        IServiceCollection services = new ServiceCollection();
        services.AddTaggedFactoryService<string, IDocumentParserService, DocumentParserServiceRepository, DocumentParserServiceFactory>(
            ServiceLifetime.Scoped, 
            Assembly.GetExecutingAssembly());


        this._serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public void FactoryRepository_Should_Registered()
    {
        var factoryRepo = this._serviceProvider.GetRequiredService<DocumentParserServiceRepository>();

        Assert.NotNull(factoryRepo);
    }

    [Fact]
    public void FactoryService_Should_Registered()
    {
        var factory = this._serviceProvider.GetRequiredService<DocumentParserServiceFactory>();

        Assert.NotNull(factory);
    }

    [Theory]
    [InlineData("Word")]
    [InlineData("Pdf")]
    [InlineData("Excel")]
    public void FactoryService_Should_CreateDocTypeParser(string docType)
    {
        var factory = this._serviceProvider.GetRequiredService<DocumentParserServiceFactory>();

        var docParser = factory.Create(docType);
        var docParserResult = docParser!.Test();

        Assert.True(docParserResult.Equals($"I am {docType}", StringComparison.InvariantCultureIgnoreCase));
    }
}