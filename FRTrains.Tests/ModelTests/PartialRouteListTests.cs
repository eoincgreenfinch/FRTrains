using FRTrains.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FRTrains.Tests
{
    [TestClass]
    public class PartialRouteListTests
    {
        List<Route> fullRouteList;

        [TestInitialize]
        public void SetUp()
        {
            //Arrange
            fullRouteList = new List<Route>();
            //"AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7"
            fullRouteList.Add(new Route(new Town("A"), new Town("B"), 5));
            fullRouteList.Add(new Route(new Town("B"), new Town("C"), 4));
            fullRouteList.Add(new Route(new Town("C"), new Town("D"), 8));
            fullRouteList.Add(new Route(new Town("D"), new Town("C"), 8));
            fullRouteList.Add(new Route(new Town("D"), new Town("E"), 6));
            fullRouteList.Add(new Route(new Town("A"), new Town("D"), 5));
            fullRouteList.Add(new Route(new Town("C"), new Town("E"), 2));
            fullRouteList.Add(new Route(new Town("E"), new Town("B"), 3));
            fullRouteList.Add(new Route(new Town("A"), new Town("E"), 7));
        }

        [TestMethod]
        public void CalculateRouteDistance()
        {
            //Arrange
            var inputRouteList = "A-B-C";
            var partialList = new PartialRouteList(fullRouteList, inputRouteList);

            //Act

            //Assert
            Assert.AreEqual(5 + 4, partialList.TotalDistance);
        }

        [TestMethod]
        public void BuildValidRoutes()
        {
            //Arrange
            var inputRouteList = "A-B-C";
            var partialList = new PartialRouteList(fullRouteList, inputRouteList);
            var townA = new Town("A");
            var townB = new Town("B");
            var townC = new Town("C");

            //Act


            //Assert
            //First Leg (A - B)
            Assert.AreEqual(townA.TownName, partialList.RouteList[0].StartTown.TownName);
            Assert.AreEqual(townB.TownName, partialList.RouteList[0].EndTown.TownName);
            //Second Leg (B - C)
            Assert.AreEqual(townB.TownName, partialList.RouteList[1].StartTown.TownName);
            Assert.AreEqual(townC.TownName, partialList.RouteList[1].EndTown.TownName);

            Assert.AreEqual(null, partialList.ErrorMessage);
            Assert.AreEqual(9, partialList.TotalDistance);
        }

        [TestMethod]
        public void BuildInvalidRoutes()
        {
            //Arrange
            var inputRouteList = "A-E-D";
            var partialList = new PartialRouteList(fullRouteList, inputRouteList);

            //Act


            //Assert
            Assert.AreEqual("NO SUCH ROUTE", partialList.ErrorMessage);
            Assert.AreEqual(-1, partialList.TotalDistance);
        }
    }
}