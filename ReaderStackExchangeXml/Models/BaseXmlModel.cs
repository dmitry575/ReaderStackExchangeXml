﻿using System;
using System.Xml.Serialization;

namespace ReaderStackExchangeXml.Models
{
    [Serializable]
    [XmlRoot(ElementName = "row", IsNullable = true)]
    public class BaseXmlModel
    {
        [XmlAttribute("Id")]
        public long Id { get; set; }
    }
}