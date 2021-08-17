using System.Xml;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Extensions
{
    public static class ReaderExtensions
    {
        /// <summary>
        /// Deserializes the XML data contained by the specified System.String
        /// </summary>
        public static T XmlDeserialize<T>(this XmlReader s)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(s);
        }
    }
}