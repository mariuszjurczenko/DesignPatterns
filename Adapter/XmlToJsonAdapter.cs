namespace Adapter;

using Newtonsoft.Json.Linq;
using System.Xml.Linq;

public class XmlToJsonAdapter : IDataAdapter
{
    public string ConvertData(string xmlData)
    {
        // Parsowanie danych XML
        var xmlDocument = XElement.Parse(xmlData);

        // Rekurencyjna konwersja XML do obiektu JToken (JSON)
        var jsonObject = new JObject
        {
            [xmlDocument.Name.LocalName] = ConvertXmlToJson(xmlDocument)
        };

        // Zwracamy wynik w formacie JSON
        return jsonObject.ToString();
    }

    private JToken ConvertXmlToJson(XElement element)
    {
        var jsonObject = new JObject();

        // Dodajemy atrybuty jako właściwości JSON
        foreach (var attribute in element.Attributes())
        {
            jsonObject[attribute.Name.LocalName] = attribute.Value;
        }

        // Jeśli element ma podelementy, przetwarzamy je rekurencyjnie
        if (element.HasElements)
        {
            foreach (var child in element.Elements())
            {
                var childJson = ConvertXmlToJson(child);

                // Jeśli klucz już istnieje, zamieniamy go na tablicę
                if (jsonObject[child.Name.LocalName] != null)
                {
                    if (jsonObject[child.Name.LocalName] is JArray array)
                    {
                        array.Add(childJson);
                    }
                    else
                    {
                        jsonObject[child.Name.LocalName] = new JArray(jsonObject[child.Name.LocalName], childJson);
                    }
                }
                else
                {
                    jsonObject[child.Name.LocalName] = childJson;
                }
            }
        }
        else
        {
            // Jeśli element jest liściem, dodajemy jego wartość
            if (!string.IsNullOrWhiteSpace(element.Value))
            {
                jsonObject["Value"] = element.Value;
            }
        }

        return jsonObject;
    }
}
