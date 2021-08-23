using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using ReaderStackExchangeXml.Ioc;
using ReaderStackExchangeXml.Models;
using System;

namespace ReaderStackExchangeXml.Tests.Ioc
{
    public class RegistryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(typeof(IReaderStackExchangeXml<User>))]
        [TestCase(typeof(IReaderStackExchangeXml<Badge>))]
        [TestCase(typeof(IReaderStackExchangeXml<Post>))]
        [TestCase(typeof(IReaderStackExchangeXml<PostHistory>))]
        [TestCase(typeof(IReaderStackExchangeXml<PostLink>))]
        [TestCase(typeof(IReaderStackExchangeXml<Tag>))]
        [TestCase(typeof(IReaderStackExchangeXml<Vote>))]
        public void CorrectRegistry(Type t, Type )
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddReaderStackXml();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var user = serviceProvider.GetService(t);
            Assert.AreNotEqual(user, null);
        }
    }
}
