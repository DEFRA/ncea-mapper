using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ncea.mapper.Extensions
{
    internal static class Serializer
    {
        public static T? Deserialize<T>(this string value)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            return (T?)xmlSerializer.Deserialize(new StringReader(value));
        }

        public static string Serialize<T>(this T value)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));

            using (var stringWriter = new StringWriter())
            {
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
                {
                    xmlSerializer.Serialize(xmlWriter, value);
                    return stringWriter.ToString();
                }
            }
        }
    }
}
