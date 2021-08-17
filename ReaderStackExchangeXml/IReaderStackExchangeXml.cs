using System.Collections.Generic;

namespace ReaderStackExchangeXml
{
    public interface IReaderStackExchangeXml<out TModel> 
    {
        /// <summary>
        /// Reading from xml file rows
        /// </summary>
        /// <param name="fileName">File name of xml</param>
        IAsyncEnumerable<TModel> ReadAsync(string fileName);
    }
}