using System;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class Vote : BaseXmlModel
    {
        [XmlElement(ElementName = "UserId", IsNullable = true)]
        public long? UserId { get; set; }

        [XmlAttribute("PostId")]
        public long PostId { get; set; }

        [XmlAttribute("VoteTypeId")]
        public int VoteTypeId { get; set; }

        [XmlAttribute("CreationDate")]
        public DateTime CreationDate { get; set; }

        [XmlElement(ElementName = "BountyAmount", IsNullable = true)]
        public int? BountyAmount { get; set; }

    }
}
