namespace Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class PriceList
    {
        public readonly IDiscount _discount;

        public abstract int CalculatePrice();

        public PriceList(IDiscount discount)
        {
            _discount = discount;
        }
    }
}
