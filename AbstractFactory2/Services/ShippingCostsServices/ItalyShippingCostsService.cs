namespace AbstractFactory2
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class ItalyShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 50;
    }
}
