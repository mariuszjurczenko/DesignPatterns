namespace AbstractFactory2
{
    /// <summary>
    /// ConcreteFactory
    /// </summary>
    public class PolandShoppingCartFactory : IShoppingCartFactory
    {
        public IShippingCostsService CreateShippingCostsService()
        {
            return new PolandShippingCostsService();
        }

        public ISpecialOfferService CreateSpecialOfferService()
        {
            return new PolandSpecialOfferService();
        }
    }
}
