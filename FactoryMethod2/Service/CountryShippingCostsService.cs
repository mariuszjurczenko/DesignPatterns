namespace FactoryMethod2
{
    /// <summary>
    /// ConcreteProduct
    /// </summary>
    internal class CountryShippingCostsService : ShippingCostsService
    {
        private readonly string _countryIdetifier;

        public CountryShippingCostsService(string countryIdetifier)
        {
            _countryIdetifier = countryIdetifier;
        }

        public override decimal ShippingCosts
        {
            get
            {
                switch (_countryIdetifier)
                {
                    case "PL":
                        return 10;
                    case "GB":
                        return 20;
                    default:
                        return 50;
                }
            }
        }
    }
}
