using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using ReaderStackExchangeXml.Extensions;
using ReaderStackExchangeXml.Models;

namespace ReaderStackExchangeXml
{
    public class ReaderStackExchangeXml<TModel> : IReaderStackExchangeXml<TModel> where TModel : BaseXmlModel
    {
        /// <summary>
        /// Reading from xml file rows
        /// </summary>
        /// <param name="fileName">File name of xml</param>
        public async IAsyncEnumerable<TModel> ReadAsync(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException($"file not found: {fileName}");
            }

            var reader = XmlReader.Create(fileName, new XmlReaderSettings
            {
                Async = true,
                IgnoreComments = true
            }
            );

            while (await reader.ReadAsync())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name.Equals("row", StringComparison.InvariantCultureIgnoreCase))
                        {
                            var data = reader.XmlDeserialize<TModel>();
                            yield return data;
                        }

                        break;
                }
            }
        }
    }
}