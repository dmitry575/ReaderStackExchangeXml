using System;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class Vote : BaseXmlModel
    {
        [XmlIgnore]
        public long? UserId { get; set; }

        [XmlAttribute("PostId")]
        public long PostId { get; set; }

        [XmlAttribute("VoteTypeId")]
        public int VoteTypeId { get; set; }

        [XmlAttribute("CreationDate")]
        public DateTime CreationDate { get; set; }

        [XmlIgnore]
        public int? BountyAmount { get; set; }

        [XmlAttribute("BountyAmount")]
        public string BountyAmountStr
        {
            get => BountyAmount.HasValue ? BountyAmount.ToString() : string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && int.TryParse(value, out int i))
                {
                    BountyAmount = i;
                }
            }
        }

        [XmlAttribute("UserId")]
        public string UserIdStr
        {
            get => UserId.HasValue ? UserId.ToString() : string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && int.TryParse(value, out int i))
                {
                    UserId = i;
                }
            }
        }

    }
}
