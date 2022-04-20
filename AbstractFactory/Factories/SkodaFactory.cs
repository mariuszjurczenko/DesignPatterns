namespace AbstractFactory
{
    class SkodaFactory : IAbstractFactory
    {
        public IAbstractCabriolet CreateCabriolet()
        {
            return new SkodaCabriolet();
        }

        public IAbstractCombi CreateCombi()
        {
            return new SkodaCombi();
        }

        public IAbstractHatchback CreateHatchback()
        {
            return new SkodaHatchback();
        }

        public IAbstractSedan CreateSedan()
        {
            return new SkodaSedan();
        }
    }
}
