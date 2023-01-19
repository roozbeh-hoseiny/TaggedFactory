using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TaggedFactory.Test.AppCore.StrategyByEnum;

namespace TaggedFactory.Test;

public class StrategyTest
{
    IServiceProvider _serviceProvider;
    public StrategyTest()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddTaggedFactoryService<IEnumerable<StrategiesEnum>, ISampleStrategyService, SampleStrategyServiceRepository, SampleStrategyServiceFactory>(
            ServiceLifetime.Scoped,
            Assembly.GetExecutingAssembly());

        this._serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public void FactoryRepository_Should_Registered()
    {
        var factoryRepo = this._serviceProvider.GetRequiredService<SampleStrategyServiceRepository>();

        Assert.NotNull(factoryRepo);
    }

    [Fact]
    public void FactoryService_Should_Registered()
    {
        var factory = this._serviceProvider.GetRequiredService<SampleStrategyServiceFactory>();

        Assert.NotNull(factory);
    }

    [Theory]
    [InlineData(new StrategiesEnum[1] { StrategiesEnum.Sum },1, 2, 3)]
    [InlineData(new StrategiesEnum[1] { StrategiesEnum.Multiplication }, 1, 8, 8)]
    [InlineData(new StrategiesEnum[1] { StrategiesEnum.Division }, 50, 25, 2)]
    [InlineData(new StrategiesEnum[1] { StrategiesEnum.Subtraction }, 50, 28, 22)]
    [InlineData(new StrategiesEnum[2] { StrategiesEnum.Sum, StrategiesEnum.Multiplication }, 2, 8, 80)]
    [InlineData(new StrategiesEnum[2] { StrategiesEnum.Sum, StrategiesEnum.Division }, 20, 5, 5)]
    public void FactoryService_Should_CreateDocTypeParser(IEnumerable<StrategiesEnum> strategy, int a, int b, long result)
    {
        var factory = this._serviceProvider.GetRequiredService<SampleStrategyServiceFactory>();

        var sut = factory.Create(strategy);
        var sutResult = sut!.Apply(a, b);

        Assert.True(sutResult == result);
    }
}
