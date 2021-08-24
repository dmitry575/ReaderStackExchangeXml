using NUnit.Framework;
using ReaderStackExchangeXml.Models;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ReaderStackExchangeXml.Tests
{
    public interface IReaderStackExchangeXmlTestCases
    {
        Task ShouldReadAsync();
    }

    public class ReaderStackExchangeXmlTestCases<T> : IReaderStackExchangeXmlTestCases where T : BaseXmlModel
    {
        public async Task ShouldReadAsync()
        {
            var reader = new ReaderStackExchangeXml<T>();
            var list = new List<T>();
            await foreach (var item in reader.ReadAsync(Path.Combine("Data", typeof(T).Name + "s.xml")))
            {
                list.Add(item);
            }

            Assert.AreEqual(3, list.Count);
            Assert.AreEqual(1, list[0].Id);
            Assert.AreEqual(2, list[1].Id);
            Assert.AreEqual(3, list[2].Id);
        }
    }

    public class ReaderStackExchangeXmlTests
    {
        [TestCaseSource("TestCases")]
        public async Task ReadAsync(IReaderStackExchangeXmlTestCases readerTest)
        {
            await readerTest.ShouldReadAsync();
        }

        private static IEnumerable<IReaderStackExchangeXmlTestCases> TestCases()
        {
            yield return new ReaderStackExchangeXmlTestCases<Badge>();
            yield return new ReaderStackExchangeXmlTestCases<Comment>();
            yield return new ReaderStackExchangeXmlTestCases<Post>();
            yield return new ReaderStackExchangeXmlTestCases<PostHistory>();
            yield return new ReaderStackExchangeXmlTestCases<PostLink>();
            yield return new ReaderStackExchangeXmlTestCases<Tag>();
            yield return new ReaderStackExchangeXmlTestCases<User>();
            yield return new ReaderStackExchangeXmlTestCases<Vote>();
        }

    }
}
