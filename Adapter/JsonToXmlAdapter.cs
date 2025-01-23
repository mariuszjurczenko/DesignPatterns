namespace Adapter;

using Newtonsoft.Json.Linq;
using System.Xml.Linq;

public class JsonToXmlAdapter : IDataAdapter
{
    public string ConvertData(string jsonData)
    {
        // Parsowanie JSON do obiektu JToken
        var jsonObject = JObject.Parse(jsonData);

        // Pobranie pierwszego klucza jako głównego elementu XML
        var rootElement = new XElement(jsonObject.Properties().First().Name);

        // Rekurencyjne przekształcenie danych JSON na XML
        ConvertJsonToXml(jsonObject.Properties().First().Value, rootElement);

        // Zwracamy XML w formacie string
        return rootElement.ToString();
    }

    private void ConvertJsonToXml(JToken jsonToken, XElement parentElement)
    {
        switch (jsonToken.Type)
        {
            case JTokenType.Object:
                foreach (var property in jsonToken.Children<JProperty>())
                {
                    var childElement = new XElement(property.Name);
                    ConvertJsonToXml(property.Value, childElement);
                    parentElement.Add(childElement);
                }
                break;

            case JTokenType.Array:
                foreach (var item in jsonToken.Children())
                {
                    var arrayItemElement = new XElement("Item");
                    ConvertJsonToXml(item, arrayItemElement);
                    parentElement.Add(arrayItemElement);
                }
                break;

            case JTokenType.Property:
                var prop = (JProperty)jsonToken;
                var element = new XElement(prop.Name);
                ConvertJsonToXml(prop.Value, element);
                parentElement.Add(element);
                break;

            case JTokenType.String:
            case JTokenType.Integer:
            case JTokenType.Float:
            case JTokenType.Boolean:
            case JTokenType.Date:
                parentElement.Value = jsonToken.ToString();
                break;

            default:
                throw new Exception($"Nieobsługiwany typ tokena JSON: {jsonToken.Type}");
        }
    }
}
