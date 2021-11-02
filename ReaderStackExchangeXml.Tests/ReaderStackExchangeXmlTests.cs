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
        
        [Test]
        public async Task ReadPost()
        {
            var reader = new ReaderStackExchangeXml<Post>();
            var list = new List<Post>();
            await foreach (var item in reader.ReadAsync(Path.Combine("Data", "Posts.xml")))
            {
                list.Add(item);
            }
            
            Assert.AreEqual(2, list[1].Id);
            Assert.AreEqual(82, list[1].ParentId);
            Assert.AreEqual(10, list[1].Score);
            Assert.AreEqual(2, list[1].PostTypeId);
            Assert.AreEqual(4, list[1].OwnerUserId);
            Assert.AreEqual(14356, list[1].LastEditorUserId);
            Assert.AreEqual(7, list[1].CommentCount);
            Assert.AreEqual("CC BY-SA 3.0", list[1].ContentLicense);
            Assert.AreEqual(DateTime.Parse("2015-03-25T13:56:10.997"), list[1].LastEditDate);
            Assert.AreEqual(DateTime.Parse("2010-07-28T20:07:41.433"), list[1].CreationDate);
            Assert.AreEqual(355, list[1].Body.Length);
            
            Assert.AreEqual(7, list[0].FavoriteCount);
            
        }
        [Test]
        public async Task ReadUser()
        {
            var reader = new ReaderStackExchangeXml<User>();
            var list = new List<User>();
            await foreach (var item in reader.ReadAsync(Path.Combine("Data", "Users.xml")))
            {
                list.Add(item);
            }
            
            Assert.AreEqual(2, list[1].Id);
            Assert.AreEqual(101, list[1].Reputation);
            Assert.AreEqual(DateTime.Parse("2010-07-28T17:09:21.300"), list[1].CreationDate);
            Assert.AreEqual("Geoff Dalgas", list[1].DisplayName);
            Assert.AreEqual(DateTime.Parse("2021-02-05T22:54:24.733"), list[1].LastAccessDate);
            Assert.AreEqual("http://stackoverflow.com", list[1].WebsiteUrl);
            Assert.AreEqual("Corvallis, OR", list[1].Location);
            Assert.AreEqual(421, list[1].AboutMe.Length);
            Assert.AreEqual(285, list[1].Views);
            Assert.AreEqual(7, list[1].UpVotes);
            Assert.AreEqual(0, list[1].DownVotes);
            Assert.AreEqual(2, list[1].AccountId);
            Assert.AreEqual("https://i.stack.imgur.com/nDllk.png?s=128&g=1", list[1].ProfileImageUrl);
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
