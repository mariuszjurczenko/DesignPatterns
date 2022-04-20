namespace FactoryMethod2
{
    internal abstract class ShippingCostsService
    {
        public abstract decimal ShippingCosts { get; }
        public override string ToString() => GetType().Name;
    }
}
