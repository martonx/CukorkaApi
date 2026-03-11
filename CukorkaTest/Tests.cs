using CukorkaApi;
using System.Net.Http.Json;

namespace CukorkaTest;

public class Tests
{
    [ClassDataSource<WebApplicationFactory>(Shared = SharedType.PerTestSession)]
    public required WebApplicationFactory WebApplicationFactory { get; init; }

    [Test]
    public async Task TestGetAll()
    {
        var client = WebApplicationFactory.CreateClient();
        var products = await client.GetFromJsonAsync<List<Product>>("http://localhost:5072/getall");
        await Assert.That(products.Count).IsEqualTo(21);
    }

    [Test]
    public async Task TestGetOne()
    {
        var client = WebApplicationFactory.CreateClient();
        var product = await client.GetFromJsonAsync<Product>("http://localhost:5072/get/1");
        await Assert.That(product.Id).IsEqualTo(1);
        await Assert.That(product.Name).IsEqualTo("Mars");
        await Assert.That(product.Price).IsEqualTo(300);
        await Assert.That(product.Stock).IsEqualTo(5);
    }
}
