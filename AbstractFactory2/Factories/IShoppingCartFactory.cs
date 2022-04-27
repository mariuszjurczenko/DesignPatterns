namespace AbstractFactory2
{
    /// <summary>
    /// Factory
    /// </summary>
    public interface IShoppingCartFactory
    {
        IShippingCostsService CreateShippingCostsService();
        ISpecialOfferService CreateSpecialOfferService();
    }
}
