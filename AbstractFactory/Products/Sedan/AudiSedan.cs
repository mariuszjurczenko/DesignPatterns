namespace AbstractFactory
{
    class AudiSedan : IAbstractSedan
    {
        public string FunctionWithSedan()
        {
            return "Metoda zwraca AudiSedan";
        }

        public string AnotherFunctionWithSedan(IAbstractCombi collaborator)
        {
            var result = collaborator.FunctionWithCombi();

            return $"Wynik współpracy AudiSedan z ({result})";
        }
    }
}
