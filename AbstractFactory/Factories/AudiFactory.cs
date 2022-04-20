namespace AbstractFactory
{
    class AudiFactory : IAbstractFactory
    {
        public IAbstractCabriolet CreateCabriolet()
        {
            return new AudiCabriolet();
        }

        public IAbstractCombi CreateCombi()
        {
            return new AudiCombi();
        }

        public IAbstractHatchback CreateHatchback()
        {
            return new AudiHatchback();
        }

        public IAbstractSedan CreateSedan()
        {
            return new AudiSedan();
        }
    }
}
