using FRTrains.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TechTalk.SpecFlow;

//TODO FR 20: These are not complete.
namespace FRTrains.Specs.Steps
{
    [Binding]
    public class RouteDistance
    {
        List<Route> fullRouteList;



        [Given(@"I have a valid set of routes")]
        public void GivenIHaveAValidSetOfRoutes()
        {
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

        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(string inputRouteList)
        {
            var partialList = new PartialRouteList(fullRouteList, inputRouteList);


            //Assert.AreEqual(,partialList.);



            //routeDistance = new Bll.RouteDistance(route);
            //routeDistance.CalcRouteDistance(route);
            //Assert.AreEqual(route, routeDistance.RouteEntered);
        }

        [Then(@"The distance should be (.*)")]
        public void ThenTheDistanceShouldBe(string distance)
        {
            //Assert.AreEqual(distance, routeDistance.Distance);
        }
    }
}