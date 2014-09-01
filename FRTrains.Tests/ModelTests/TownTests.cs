using FRTrains.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FRTrains.Tests
{
    [TestClass]
    public class TownTests
    {
        Town town;

        [TestMethod]
        public void CreateNullTown()
        {
            //Arrange
            town = new Town();

            //Act
            town.TownName = "A";

            //Assert
            Assert.AreEqual("A", town.TownName);
        }

        [TestMethod]
        public void CreateNamedTown()
        {
            //Arrange
            town = new Town("B");

            //Act

            //Assert
            Assert.AreEqual("B", town.TownName);
        }
    }
}
