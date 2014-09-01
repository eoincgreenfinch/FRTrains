namespace FRTrains.Models
{
    //Specification says Town = Node, Mathematical modeling calls them Vertex.
    //Specification says TownName will only ever be a single char long.
    public class Town
    {
        public string TownName { get; set; }

        public Town() { }

        public Town(string townName)
        {
            TownName = townName;
        }

        //TODO FR 80: If the only reason town class exists is to assign a value using
        //the constructor, see if there is an alternative.
    }
}
