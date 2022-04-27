namespace AbstractFactory2
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class PolandShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 10;
    }
}
