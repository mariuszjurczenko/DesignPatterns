namespace Bridge
{
    /// <summary>
    /// RefinedAbstraction
    /// </summary>
    public class RadioPricelist : PriceList
    {
        public RadioPricelist(IDiscount coupon) : base(coupon)
        {
        }

        public override int CalculatePrice()
        {
            return 300 - _discount.DiscountValue;
        }
    }
}
