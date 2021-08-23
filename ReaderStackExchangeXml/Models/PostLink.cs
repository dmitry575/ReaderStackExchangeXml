using System;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    /// <summary>
    /// Post links xml file
    /// </summary>
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class PostLink : BaseXmlModel
    {
        [XmlAttribute("CreationDate")]
        public DateTime CreationDate { get; set; }

        [XmlAttribute("PostId")]
        public long PostId { get; set; }

        [XmlAttribute("RelatedPostId")]
        public long RelatedPostId { get; set; }

        [XmlAttribute("LinkTypeId")]
        public int LinkTypeId { get; set; }
    }
}
