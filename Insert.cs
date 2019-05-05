using System;
using System.Linq;

namespace VisualGraph
{
    /// <summary>
    /// Inserts the Values from Form1 into the Dijekstra Algorithm
    /// </summary>
    public class Insert
    {
        public Dijekstra dijekstra;

        public Insert(Dijekstra dij1)
        {
            dijekstra = dij1;
        }

        public void insertEdge(String start, String end, double weight)
        {
            dijekstra.initialVertex.Add(dijekstra.vertexList.IndexOf(NameToVertex(start)));
            dijekstra.finalVertex.Add(dijekstra.vertexList.IndexOf(NameToVertex(end)));
            dijekstra.weights.Add(weight);
        }

        public void insertVertex(String name)
        {
            dijekstra.vertexList.Add(new Vertex(name));
        }

        Vertex NameToVertex(String name)
        {
            return dijekstra.vertexList.Where(x => x.name == name).ToList()[0];
        }

        public String getVertexFromIndex(int index)
        {
            return dijekstra.vertexList[index].name;
        }
    }
}
