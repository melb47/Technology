using System;
using TechnologyNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologyTestsNS
{
    [TestClass]
    public class SmartPhoneTests
    {
        SmartPhone phone;
        [TestInitialize]
        public void CreateSmartPhoneObject()
        {
            phone = new SmartPhone("Molly");
        }
        [TestMethod]
        public void SmartPhoneInitializesLocked()
        {
            Assert.IsTrue(phone.IsLocked);
        }
        [TestMethod]
        public void UnlockPhoneWorks()
        {
            phone.Unlock();
            Assert.IsFalse(phone.IsLocked);
        }
        [TestMethod]
        public void PlayMovieReturnsCorrectResponse()
        {
            Assert.AreEqual("You cannot watch a movie from a disc", phone.PlayMovie());
        }
        [TestMethod]
        public void AssignIdReturnsUniqueId()
        {
            SmartPhone id_test = new SmartPhone("Jerry");
            Assert.AreNotEqual(id_test.objectId, phone.objectId);
        }
    }
}
