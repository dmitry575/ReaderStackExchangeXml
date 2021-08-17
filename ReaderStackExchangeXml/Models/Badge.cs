﻿using System;
using System.Xml;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class Badge:BaseXmlModel
    {
        [XmlAttribute("UserId")]
        public long UserId { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }


        [XmlAttribute("Date")]
        public DateTime Date { get; set; }

        [XmlAttribute("Class")]
        public int Class { get; set; }


        [XmlIgnore]
        public bool TagBased { get; set; }

        [XmlAttribute("TagBased")]
        public string TagBasedStr
        {
            get { return TagBased.ToString(); }
            set
            {
                TagBased = XmlConvert.ToBoolean(value.ToLower());
            }
        }
    }
}
