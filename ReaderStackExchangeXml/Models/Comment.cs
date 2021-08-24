using System;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class Comment : BaseXmlModel
    {
        [XmlAttribute("PostId")]
        public long PostId { get; set; }

        [XmlAttribute("UserId")]
        public long UserId { get; set; }

        [XmlAttribute("Score")]
        public long Score { get; set; }

        [XmlAttribute("Text")]
        public string Text { get; set; }

        [XmlAttribute("CreationDate")]
        public DateTime CreationDate { get; set; }

        [XmlAttribute("ContentLicense")]
        public string ContentLicense { get; set; }

    }
}
