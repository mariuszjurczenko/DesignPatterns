namespace Bridge
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class TenEuroDiscount : IDiscount
    {
        public int DiscountValue { get => 10; }
    }
}
