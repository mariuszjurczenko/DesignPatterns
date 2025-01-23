namespace Adapter;

public class DataProcessor
{
    private readonly IDataAdapter _dataAdapter;

    // Konstruktor przyjmuje obiekt implementujący IDataAdapter
    public DataProcessor(IDataAdapter dataAdapter)
    {
        _dataAdapter = dataAdapter;
    }

    // Metoda przetwarzania danych
    public string ProcessData(string inputData)
    {
        string convertedData = _dataAdapter.ConvertData(inputData);
        return convertedData;
    }
}
