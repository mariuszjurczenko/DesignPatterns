namespace AbstractFactory
{
    public interface IAbstractSedan
    {
        string FunctionWithSedan();

        string AnotherFunctionWithSedan(IAbstractCombi collaborator);
    }
}
