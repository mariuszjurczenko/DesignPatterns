using FactoryMethod2;

Console.Title = "Factory Method";

var factories = new List<ShippingCostsFactory>
{
    new CodeShippingCostsFactory(Guid.NewGuid()),
    new CountryShippingCostsFactory("PL")
};

foreach (var factory in factories)
{
    var shippingCostsService = factory.CreateShippingCostsService();
    Console.WriteLine($"Koszt wysyłki to {shippingCostsService.ShippingCosts} zł. i pochodzi z {shippingCostsService}");
}

Console.ReadKey();