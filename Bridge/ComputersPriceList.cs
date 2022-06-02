namespace Bridge
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class ComputersPriceList : PriceList
    {
        public ComputersPriceList(IDiscount discount) : base(discount)
        {
        }

        public override int CalculatePrice()
        {
            return 2000 - _discount.DiscountValue;
        }
    }
}
