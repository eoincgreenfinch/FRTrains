namespace FRTrains.Models
{
    //Specification says Route = Edge (also called edge in mathematical modelling).
    //NOTE: A route represents a single edge only, with a start and end points and length.
    //If you want to make a route with multiple points, then you need a list of routes.
    public class Route
    {
        public Town StartTown { get; set; }
        public Town EndTown { get; set; }
        public int Distance { get; set; }

        public Route() { }

        public Route(Town startTown, Town endTown, int distance)
        {
            StartTown = startTown;
            EndTown = endTown;
            Distance = distance;
        }
    }
}
