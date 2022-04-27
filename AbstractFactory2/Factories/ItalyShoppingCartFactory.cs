namespace AbstractFactory2
{
    /// <summary>
    /// ConcreteFactory
    /// </summary>
    public class ItalyShoppingCartFactory : IShoppingCartFactory
    {
        public IShippingCostsService CreateShippingCostsService()
        {
            return new ItalyShippingCostsService();
        }

        public ISpecialOfferService CreateSpecialOfferService()
        {
            return new ItalySpecialOfferService();
        }
    }
}
