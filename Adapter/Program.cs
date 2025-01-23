using Adapter;

class Program
{
    static void Main()
    {
        // Dane JSON do konwersji
        string jsonData = @"
        {
          ""Dane"": {
            ""Orders"": {
              ""Order"": {
                ""Warehouse"": ""11K02"",
                ""ItemID"": ""M-E20511000"",
                ""LotNumber"": ""404392660000"",
                ""SourceLocation"": ""01B01"",
                ""TargetLocation"": ""ITS03B"",
                ""QuantityPicked"": ""2070"",
                ""Unit"": ""m"",
              }
            },
            ""User"": {
              ""Name"": {
                ""Value"": ""John""
              },
              ""Age"": {
                ""Value"": ""30""
              },
              ""Hobbies"": {
                ""Item"": [ ""reading"", ""traveling"", ""gaming"" ]
              },
              ""Address"": {
                ""Street"": ""123 Main St"" ,
                ""City"": ""New York""
              }
            }
          }
        }";

        // Wybór konwersji JSON → XML
        IDataAdapter jsonToXmlAdapter = new JsonToXmlAdapter();
        var dataProcessor = new DataProcessor(jsonToXmlAdapter);
        var resultxmlData = dataProcessor.ProcessData(jsonData);

        // Wyświetlenie wyniku
        Console.WriteLine("Wynik XML:");
        Console.WriteLine(resultxmlData);

        // Dane XML do konwersji
        string xmlData = @"<?xml version=""1.0"" encoding=""utf-8"" standalone=""no""?>
        <Dane>
          <Orders>
            <Order Warehouse=""11M02"" ItemID=""M-E20511000"" LotNumber=""404392660000"" SourceLocation=""01B01"" TargetLocation=""ITS03B"" QuantityPicked=""2070"" Unit=""m""/>
          </Orders>
          <User>
              <Name>John</Name>
              <Age>30</Age>
              <Hobbies>
                <Item>reading</Item>
                <Item>traveling</Item>
                <Item>gaming</Item>
              </Hobbies>
              <Address>
                <Street>123 Main St</Street>
                <City>New York</City>
              </Address>
           </User>
        </Dane>";

        // Tworzenie instancji adaptera
        IDataAdapter xmlToJsonAdapter = new XmlToJsonAdapter();
        dataProcessor = new DataProcessor(xmlToJsonAdapter);
        var resultjsonData = dataProcessor.ProcessData(xmlData);

        // Wyświetlenie wyniku
        Console.WriteLine("Wynik JSON:");
        Console.WriteLine(resultjsonData);
    }
}

