using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRTrains.Models
{
    //To get a route with multiple towns (i.e. A-B-C) you simply create a list of
    //routes where the EndTown of Route[1] becomes the StartTown of Route[2]. i.e:
    //Route[0].StartTown="A", Route[0].EndTown="B", Route[0].Distance=5
    //Route[1].StartTown="B", Route[1].EndTown="C", Route[0].Distance=8
    //This information can be stored in the same way as the full list of routes and
    //is just a smaller list.
    //This way the entire distance of a route could simply be stored with the route,
    //and not have to be calculated. Although a distance calculation behaviour
    //is provided encase distances are changed.
    //Another benefit to this approach is that you can check the existance of a route
    //by checking the full list which should be faster than using an algorithm to check
    //every time (I'll do both out of interest and test later).

    public class PartialRouteList
    {
        public string RouteId { get; set; }
        public int TotalDistance { get; set; }
        public List<Route> RouteList { get; set; }

        public string ErrorMessage { get; set; }


        public PartialRouteList(List<Route> masterRouteList, string routes)
        {
            BuildRoutes(masterRouteList, routes);
            RouteId = routes;
        }

        public void CalcTotalRouteDistance()
        {
            if (string.IsNullOrWhiteSpace(ErrorMessage))
                TotalDistance = RouteList.Sum(x => x.Distance);
            else
                TotalDistance = -1;
        }

        //TODO FR 30: Consider extracting this to the BLL later
        private void BuildRoutes(List<Route> masterRouteList, string routes)
        {
            routes = routes.Trim();
            string[] routeItems = routes.Split('-');
            int countOfRoutes = routeItems.Count();

            var routeList = new List<Route>();
            var start = new Town();
            var end = new Town();

            for (int i = 0; i < countOfRoutes - 1; i++)
            {
                start.TownName = routeItems[i];
                end.TownName = routeItems[i + 1];

                //This is how we check against the full list as described above (part 1).
                routeList.AddRange(masterRouteList.Where
                    (
                        x => (x.StartTown.TownName == start.TownName)
                        && (x.EndTown.TownName == end.TownName)
                    ));
            }

            //Part 1 above adds all valid routes to another list but this does not mean
            //the whole route is valid. This simple check is done to verify the full route
            //and nullify it if it is invalid. This way you either get a valid route or
            //nothing as opposed to getting a partially valid route.
            if (routeList.Count < countOfRoutes - 1)
            {
                routeList = null;
                ErrorMessage = "NO SUCH ROUTE";
            }
            else
            {
                RouteList = routeList;
                ErrorMessage = null;
            }

            CalcTotalRouteDistance();
        }
    }
}