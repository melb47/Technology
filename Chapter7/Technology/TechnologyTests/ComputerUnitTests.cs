using System;
using TechnologyNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologyTestsNS
{
    [TestClass]
    public class ComputerUnitTests
    {
        Computer test_computer;

        [TestInitialize]
        public void CreateComputerObject()
        {
            test_computer = new Computer("mom");
        }
        
        [TestMethod]
        public void ComputerProperlyInitializes()
        {
            Assert.AreEqual(false, test_computer.PowerOn);
            Assert.AreEqual(false, test_computer.InternetConnected);
        }
        [TestMethod]
        public void TurnOnWorks()
        {
            test_computer.TurnOn();
            Assert.AreEqual(true, test_computer.PowerOn);
            Assert.AreEqual(true, test_computer.InternetConnected);
        }
        [TestMethod]
        public void PlayMovieCorrectAfterTurningOn()
        {
            test_computer.TurnOn();
            Assert.AreEqual("Insert Disc", test_computer.PlayMovie());
        }
        [TestMethod]
        public void MovieWontPlayWhenOff()
        {
            Assert.AreEqual("You gotta turn it on first", test_computer.PlayMovie());
        }
        [TestMethod]
        public void AssignIdReturnsUniqueId()
        {
            Computer id_test = new Computer("Jerry");
            Assert.AreNotEqual(id_test.objectId, test_computer.objectId);
        }
    }
}
