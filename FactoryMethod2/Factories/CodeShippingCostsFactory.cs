namespace FactoryMethod2
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    internal class CodeShippingCostsFactory : ShippingCostsFactory
    {
        private readonly Guid _code;

        public CodeShippingCostsFactory(Guid code)
        {
            _code = code;
        }

        public override ShippingCostsService CreateShippingCostsService()
        {
            return new CodeShippingCostsService(_code);
        }
    }
}
