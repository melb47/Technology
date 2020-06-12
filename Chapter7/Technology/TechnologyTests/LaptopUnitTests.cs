using System;
using System.Reflection;
using TechnologyNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologyTestsNS
{
    [TestClass]
    public class LaptopUnitTests
    {
        Laptop example;

        [TestInitialize]
        public void CreateLaptopObject()
        {
            example = new Laptop("Mary", false);
        }
        [TestMethod]
        public void InitializesWithReadOnlyValue()
        {
            Assert.IsFalse(example.HasDiscDrive);
        }
        [TestMethod]
        public void CannotPlayMovie()
        {
            Assert.AreEqual("You don't have a disc drive to play a movie", example.PlayMovie());
        }
        [TestMethod]
        public void ShutLidReturnsNoInternet()
        {
            example.ShutLid();
            Assert.IsFalse(example.InternetConnected);
        }
        [TestMethod]
        public void AssignIdReturnsUniqueId()
        {
            Laptop id_test = new Laptop("Jerry", true);
            Assert.AreNotEqual(id_test.objectId, example.objectId);
        }
    }
}
