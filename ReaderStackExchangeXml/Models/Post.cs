using System;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class Post : BaseXmlModel
    {
        [XmlAttribute("PostTypeId")] public int PostTypeId { get; set; }

        [XmlAttribute("AcceptedAnswerId")] public long AcceptedAnswerId { get; set; }

        [XmlAttribute("CreationDate")] public DateTime CreationDate { get; set; }

        [XmlAttribute("Score")] public long Score { get; set; }

        [XmlIgnore]
        public long? ViewCount { get; set; }

        [XmlAttribute("Body")] 
        public string Body { get; set; }

        [XmlAttribute("OwnerUserId")] 
        public long OwnerUserId { get; set; }

        [XmlAttribute("LastEditorUserId")] 
        public long LastEditorUserId { get; set; }

        [XmlIgnore]
        public DateTime? LastEditDate { get; set; }

        [XmlAttribute("LastActivityDate")] 
        public DateTime LastActivityDate { get; set; }

        [XmlAttribute("Title")] 
        public string Title { get; set; }

        [XmlAttribute("Tags")] 
        public string Tags { get; set; }

        [XmlAttribute("AnswerCount")] 
        public int AnswerCount { get; set; }

        [XmlAttribute("CommentCount")] 
        public int CommentCount { get; set; }

        [XmlAttribute("FavoriteCount")] 
        public int FavoriteCount { get; set; }

        [XmlAttribute("ContentLicense")] 
        public string ContentLicense { get; set; }

        [XmlIgnore] 
        public int? ParentId { get; set; }

        [XmlIgnore] 
        public DateTime? CommunityOwnedDate { get; set; }

        [XmlIgnore] 
        public DateTime? ClosedDate { get; set; }

        [XmlAttribute("ParentId")]
        public string ParentIdStr
        {
            get => ParentId.HasValue ? ParentId.ToString() : string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && int.TryParse(value, out var i))
                {
                    ParentId = i;
                }
            }
        }
        
        [XmlAttribute("CommunityOwnedDate")] 
        public string CommunityOwnedDateStr
        {
            get => CommunityOwnedDate.HasValue ? CommunityOwnedDate.ToString() : string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && DateTime.TryParse(value, out var i))
                {
                    CommunityOwnedDate = i;
                }
            }
        }
        
        [XmlAttribute("ClosedDate")] 
        public string ClosedDateStr
        {
            get => ClosedDate.HasValue ? ClosedDate.ToString() : string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && DateTime.TryParse(value, out var i))
                {
                    ClosedDate = i;
                }
            }
        }

        [XmlAttribute("ViewCount")]
        public string ViewCountStr
        {
            get => ViewCount.HasValue ? ViewCount.ToString() : string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && long.TryParse(value, out var i))
                {
                    ViewCount = i;
                }
            }
        }

        [XmlAttribute("LastEditDate")]
        public string LastEditDateStr
        {
            get => LastEditDate.HasValue ? LastEditDate.ToString() : string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value) && DateTime.TryParse(value, out var i))
                {
                    LastEditDate = i;
                }
            }
        }
    }
}