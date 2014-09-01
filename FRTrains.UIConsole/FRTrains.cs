
using FRTrains.Models;
using System;
using System.Collections.Generic;
namespace FRTrains.UIConsole
{
    class FRTrains
    {
        static void Main()
        {
            List<Route> masterList;

            masterList = new List<Route>();
            //"AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7"
            masterList.Add(new Route(new Town("A"), new Town("B"), 5));
            masterList.Add(new Route(new Town("B"), new Town("C"), 4));
            masterList.Add(new Route(new Town("C"), new Town("D"), 8));
            masterList.Add(new Route(new Town("D"), new Town("C"), 8));
            masterList.Add(new Route(new Town("D"), new Town("E"), 6));
            masterList.Add(new Route(new Town("A"), new Town("D"), 5));
            masterList.Add(new Route(new Town("C"), new Town("E"), 2));
            masterList.Add(new Route(new Town("E"), new Town("B"), 3));
            masterList.Add(new Route(new Town("A"), new Town("E"), 7));

            Console.WriteLine("Master List:");
            foreach (var route in masterList)
            {
                Console.WriteLine("Start = {0}, End = {1}, Distance = {2}, Route = {0}{1}{2}", route.StartTown.TownName, route.EndTown.TownName, route.Distance);
            }

            //Q: 1 to 5
            RouteDistance(masterList);

            //Q: 6 & 7
            RoutesWithMaxStops();


            //Q: 8


            //Q: 9


            //Q: 10

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadLine();

        }

        private static void RoutesWithMaxStops()
        {
            Console.WriteLine("\nQ: 6 & 7 - Find the route with max num of stops:");
            Town start = new Town("C");
            Town end = new Town("C");
            //int maxStops = 3;

            //TODO FR 01: Continue from here...Q6 & 7
            //int result = RoutesWithMaxNoOfStops(start, end, maxStops);

            //Console.WriteLine("No of routes starting at {0} and ending at {1} with stops less than {2} stops = {3}", start.TownName, end.TownName, maxStops, result);
        }

        private static void RouteDistance(List<Route> masterList)
        {
            List<PartialRouteList> checkRoutes = new List<PartialRouteList>();
            checkRoutes.Add(new PartialRouteList(masterList, "A-B-C"));
            checkRoutes.Add(new PartialRouteList(masterList, "A-D"));
            checkRoutes.Add(new PartialRouteList(masterList, "A-D-C"));
            checkRoutes.Add(new PartialRouteList(masterList, "A-E-B-C-D"));
            checkRoutes.Add(new PartialRouteList(masterList, "A-E-D"));

            Console.WriteLine("\nQ: 1 to 5 - Find the route distance:");
            for (int i = 0; i < checkRoutes.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(checkRoutes[i].ErrorMessage))
                    Console.WriteLine("Q{0}. {1,-10} Total distance = {2}", i + 1, checkRoutes[i].RouteId, checkRoutes[i].TotalDistance);
                else
                    Console.WriteLine("Q{0}. {1,-10} {2} ", i + 1, checkRoutes[i].RouteId, checkRoutes[i].ErrorMessage);
            }

        }
    }
}
