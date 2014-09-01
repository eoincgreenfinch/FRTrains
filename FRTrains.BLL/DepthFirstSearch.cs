using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRTrains.BLL
{
    //TODO FR 50: More research required, complete later.
    class DepthFirstSearch
    {
        public DepthFirstSearch()
        {
            //https://www.youtube.com/watch?v=fI6X6IBkzcw
            //https://www.youtube.com/watch?v=uT1p5Eiw9CE
            //Most of this code was stolen from the java version at the videos
            //above.
            //TODO FR 40: Fix this to work with lists instead of reading from
            //file.
            //TODO FR 60: Write tests for this.
            Search();


            throw new NotImplementedException();
        }

        private void Search()
        {
            throw new NotImplementedException();
        }
    }

    class Neighbor
    {
        public int VertexNum { get; set; }
        public Neighbor Next { get; set; }

        public Neighbor(int vnum, Neighbor nbr)
        {
            VertexNum = vnum;
            Next = nbr;
        }
    }

    class Vertex
    {
        string name;
        Neighbor adjList;

        public Vertex(string name, Neighbor neighbours)
        {
            this.name = name;
            adjList = neighbours;
        }
    }

    class Graph
    {
        //Vertex[] adjLists;

        public Graph(string file)
        {
            //scanner sc = new scanner(new File(file));
            //string graphType = sc.next();
            //bool undirected = true;

            //adjLists = new Vertex[sc.nextInt()];

            //for (int v = 0; v < adjLists.Length; v++)
            //{
            //    adjLists[v] = new Vertex(sc.next(), null);
            //}

            //while (sc.hasNext())
            //{
            //    int v1 = indexForName(sc.next());
            //    int v2 = indexForName(sc.next());

            //    adjLists[v1].adjList = new Neighbor(v2, adjLists[v1].adjList);
            //    if(undirected)
            //    {
            //        adjLists[v2].adjList = new Neighbor(v1, adjLists[v2].adjList);
            //    }
            //}
        }


        int indexForName(string name)
        {
            //for (int v = 0; v < adjLists.Length; v++)
            //{
            //    if(adjLists[v].name.equals(name))
            //    {
            //        return v;
            //    }
            //}
            return -1;
        }



        private void dfs(int v, bool[] visited)
        {
            //visited[v] = true;
            //Console.WriteLine("visiting " + adjLists[v].name);

            //for (Neighbor nbr = adjLists[v].adjList; nbr != null; nbr = nbr.Next)
            //{
            //    Console.WriteLine(adjLists[v].name + "--" + adjLists[nbr.VertexNum].name);
            //    dfs(nbr.VertexNum, visited);
            //}
        }

        public void dfs()
        {
            //bool[] visited = new bool[adjLists.Length];
            //for (int v = 0; v < visited.Length; v++)
            //{
            //    if (!visited[v])
            //    {
            //        Console.WriteLine("\nStarting at " + adjLists[v].name);
            //        dfs(v, visited);
            //    }
            //}
        }

        public void print()
        {
            //Console.WriteLine();
            //for (int v = 0; v < adjLists.Length; v++)
            //{
            //    Console.WriteLine(adjLists[v].name);
            //    for (int Neighbor nbr = adjLists[v].adjList; nbr != null; nbr=nbr.next);
            //    {
            //        Console.WriteLine("--> "+adjLists[nbr.vertexNum].name);
            //    }
            //    Console.WriteLine();
            //}
        }
    }


}
