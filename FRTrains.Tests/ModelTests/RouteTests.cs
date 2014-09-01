using FRTrains.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FRTrains.Tests
{
    [TestClass]
    public class RouteTests
    {
        Route route;

        [TestMethod]
        public void CreateNullRoute()
        {
            //Arrange
            route = new Route();
            var startTown = new Town("A");
            var endTown = new Town("B");

            //Act
            route.StartTown = startTown;
            route.EndTown = endTown;
            route.Distance = 5;

            //Assert
            Assert.AreEqual(startTown, route.StartTown);
            Assert.AreEqual(endTown, route.EndTown);
            Assert.AreEqual(5, route.Distance);
        }

        [TestMethod]
        public void CreateNamedRoute()
        {
            //Arrange
            var startTown = new Town("B");
            var endTown = new Town("C");
            var distance = 4;

            //Act
            route = new Route(startTown, endTown, distance);

            //Assert
            Assert.AreEqual(startTown, route.StartTown);
            Assert.AreEqual(endTown, route.EndTown);
            Assert.AreEqual(distance, route.Distance);
        }
    }
}
