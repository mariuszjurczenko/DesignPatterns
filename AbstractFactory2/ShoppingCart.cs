namespace AbstractFactory2
{
    /// <summary>
    /// Client 
    /// </summary>
    public class ShoppingCart
    {
        private readonly IShippingCostsService _shippingCostsService;
        private readonly ISpecialOfferService _specialOfferService;
        private int _orderCosts;

        public ShoppingCart(IShoppingCartFactory factory)
        {
            _shippingCostsService = factory.CreateShippingCostsService();
            _specialOfferService = factory.CreateSpecialOfferService();
            _orderCosts = 500;
        }

        public void CalculateCosts()
        {
            Console.WriteLine($"Całkowity koszt zamówienia to: {_orderCosts - (_orderCosts / 100 * _specialOfferService.DiscountPercentage) + _shippingCostsService.ShippingCosts }");
        }
    }
}
