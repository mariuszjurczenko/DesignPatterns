namespace Bridge
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class TVPriceList : PriceList
    {
        public TVPriceList(IDiscount coupon) : base(coupon)
        {
        }

        public override int CalculatePrice()
        {
            return 500 - _discount.DiscountValue;
        }
    }
}
