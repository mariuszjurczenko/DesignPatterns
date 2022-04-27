namespace AbstractFactory2
{
    /// <summary>
    /// ConcreteFactory
    /// </summary>
    public class EnglandShoppingCartFactory : IShoppingCartFactory
    {
        public IShippingCostsService CreateShippingCostsService()
        {
            return new EnglandShippingCostsService();
        }

        public ISpecialOfferService CreateSpecialOfferService()
        {
            return new EnglandSpecialOfferService();
        }
    }
}
