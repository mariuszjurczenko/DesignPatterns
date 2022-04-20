namespace FactoryMethod2
{
    /// <summary>
    /// ConcreteCreator
    /// </summary>
    internal class CountryShippingCostsFactory : ShippingCostsFactory
    {
        private readonly string _countryIdentifier;

        public CountryShippingCostsFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override ShippingCostsService CreateShippingCostsService()
        {
            return new CountryShippingCostsService(_countryIdentifier);
        }
    }
}
