namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractCabriolet CreateCabriolet();

        IAbstractCombi CreateCombi();

        IAbstractHatchback CreateHatchback();

        IAbstractSedan CreateSedan();
    }
}
