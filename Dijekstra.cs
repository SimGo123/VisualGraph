using System;
using System.Collections.Generic;
using System.Linq;

namespace VisualGraph
{
    /// <summary>
    /// Executes the Dijekstra algorithm
    /// </summary>
    public class Dijekstra
    {
        public double[,] adjacencyMatrix;
        public List<Vertex> vertexList = new List<Vertex>();
        public List<int> initialVertex = new List<int>();
        public List<int> finalVertex = new List<int>();
        public List<double> weights = new List<double>();
        List<Vertex> queue = new List<Vertex>();
        List<Vertex> done = new List<Vertex>();
        double[] distances;
        int initialVertexNr;

        public void createMatrix()
        {
            adjacencyMatrix = new double[vertexList.Count, vertexList.Count];
            for (int i = 0; i < initialVertex.Count; i++)
            {
                adjacencyMatrix[initialVertex[i], finalVertex[i]] = weights[i];
                adjacencyMatrix[finalVertex[i], initialVertex[i]] = weights[i];
            }
            distances = new double[vertexList.Count];
            for (int i = 0; i < distances.Length; i++) distances[i] = Double.MaxValue;
        }

        public double[] DijekstraStart(Vertex initialVertex1)
        {
            initialVertexNr = vertexList.IndexOf(initialVertex1);
            distances[initialVertexNr] = 0;
            done.Add(vertexList[initialVertexNr]);
            DijekstraGo(initialVertex1, 0);
            return distances;
        }

        void DijekstraGo(Vertex k, double weight)
        {
            for (int i = 0; i < vertexList.Count; i++)
            {
                if (adjacencyMatrix[vertexList.IndexOf(k), i] != 0
                    && adjacencyMatrix[vertexList.IndexOf(k), i] + weight < distances[i])
                {
                    distances[i] = adjacencyMatrix[vertexList.IndexOf(k), i] + weight;
                    if (!done.Contains(vertexList[i])) queue.Add(vertexList[i]);
                }
            }
            queue.Remove(k);
            done.Add(k);
            queue.Sort(Compare);
            if (queue.Count == 0) return;
            DijekstraGo(queue[0], adjacencyMatrix[vertexList.IndexOf(k), vertexList.IndexOf(queue[0])] + weight);
        }

        Vertex NameToKnoten(String name)
        {
            return vertexList.Where(x => x.name == name).ToList()[0];
        }

        int Compare(Vertex i, Vertex j)
        {
            if (adjacencyMatrix[initialVertexNr, vertexList.IndexOf(i)] > adjacencyMatrix[initialVertexNr, vertexList.IndexOf(j)]) return 1;
            else if (adjacencyMatrix[initialVertexNr, vertexList.IndexOf(i)] < adjacencyMatrix[initialVertexNr, vertexList.IndexOf(j)]) return -1;
            else return 0;
        }
    }
}
