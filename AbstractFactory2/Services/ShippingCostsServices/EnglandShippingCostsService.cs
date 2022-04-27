namespace AbstractFactory2
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    public class EnglandShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 20;
    }
}
