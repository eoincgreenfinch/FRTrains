using FRTrains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRTrains.BLL
{
    class DijkstraSearch
    {
        public DijkstraSearch(List<Route> allPaths, Town start, Town end)
        {
            //TODO FR 50: More research required, complete later.
            //https://www.youtube.com/watch?v=xT5o1QCeWS8
            //https://www.youtube.com/watch?v=8Ls1RqHCOPw
            //https://www.youtube.com/watch?v=zXfDYaahsNA
            //throw new NotImplementedException();

            Search(allPaths, start, end);

        }

        private void Search(List<Route> allPaths, Town start, Town end)
        {
            //sudo code stolen from: :)
            //https://www.youtube.com/watch?v=zXfDYaahsNA
            /* S = Source, V=Vertex(Town), route=edge
             * for each neighbouring V of S
             *      set distance(D) of V to weight(W) of route (S->T)
             *          i.e. D(V)=Wt(S,V)
             *      add V to the stack
             * for all other towns except S, set distance to either int.max or -1
             * 
             * do
             *      remove the shortest(M) DV, from stack
             *      
             *      for each neighbouring W of M
             *          if d(W) is infinity
             *              d(W) = d(M) + wt(m,w)
             *              add w to stack
             *          else
             *              d(w)=min(d(w), d(m)+wt(m,w))
             * while K is not empty
             */

            throw new NotImplementedException();
        }
    }
}
