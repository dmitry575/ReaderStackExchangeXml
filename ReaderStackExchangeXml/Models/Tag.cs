using System;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class Tag:BaseXmlModel
    {
               [XmlAttribute("TagName")]
        public string TagName { get; set; }

        [XmlAttribute("Count")]
        public int Count { get; set; }

        [XmlIgnore]
        public int? ExcerptPostIdValue { get; set; }

        [XmlAttribute("ExcerptPostId")]
        public int ExcerptPostId { get => ExcerptPostIdValue.HasValue ? ExcerptPostIdValue.Value : 0; set { ExcerptPostIdValue = value; } }

        [XmlIgnore]
        public int? WikiPostIdValue { get; set; }
        [XmlAttribute("WikiPostId")]
        public int WikiPostId { get => WikiPostIdValue.HasValue ? WikiPostIdValue.Value : 0; set { WikiPostIdValue = value; } }
    }
}
