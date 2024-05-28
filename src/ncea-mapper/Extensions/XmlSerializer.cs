using System.Xml;
using System.Xml.Serialization;

namespace Ncea.Mapper.Extensions
{
    public static class Serializer
    {
        public static T? Deserialize<T>(this string value)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            return (T?)xmlSerializer.Deserialize(new StringReader(value));
        }

        public static string Serialize<T>(this T value, XmlSerializerNamespaces? namespaces = null)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
                {
                    xmlSerializer.Serialize(xmlWriter, value, namespaces);
                    return stringWriter.ToString();
                }
            }
        }
    }
}
