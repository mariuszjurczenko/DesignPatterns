namespace FactoryMethod2
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    internal class CodeShippingCostsService : ShippingCostsService
    {
        private readonly Guid _code;

        public CodeShippingCostsService(Guid code)
        {
            _code = code;
        }

        public override decimal ShippingCosts
        {
            get => 25;
        }
    }
}
