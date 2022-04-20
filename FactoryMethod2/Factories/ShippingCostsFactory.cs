namespace FactoryMethod2
{
    /// <summary>
    /// Creator
    /// </summary>
    internal abstract class ShippingCostsFactory
    {
        public abstract ShippingCostsService CreateShippingCostsService();
    }
}
