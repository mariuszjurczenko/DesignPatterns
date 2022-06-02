namespace Bridge
{
    /// <summary>
    /// ConcreteImplementor
    /// </summary>
    public class NoDiscount : IDiscount
    {
        public int DiscountValue { get => 0; }
    }
}
