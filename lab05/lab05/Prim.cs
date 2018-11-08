using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Prim
    {

        private List<int> vertexes = null;
        private List<Edge> used = null;
        private IGraph graph = null;

        public void ShowTree(IGraph graph)
        {
            this.graph = graph;
            vertexes = new List<int>();
            used = new List<Edge>();
            vertexes.Add(0);

            while (vertexes.Count() != graph.GetVertexesAmount())
            {
                int size = vertexes.Count();
                int vertexPosition = size - 1;
                int vertexNumber = vertexes.ElementAt(vertexPosition);
                List<Edge> edges = GetStepEdges();

                while (vertexes.Count() == size)
                {
                    Edge edge = MinWeightEdge(edges);
                    var vertex = GetExcludedTreeVertexByEdge(edge);

                    if (vertexes.IndexOf(vertex.GetNumber()) == -1)
                    {
                        vertexes.Add(vertex.GetNumber());
                        used.Add(edge);
                    }
                    else
                    {
                        edges.RemoveAt(edges.IndexOf(edge));
                    }
                    
                }
            }

            Show();
        }

        private List<Edge> GetStepEdges()
        {
            List<Edge> edges = new List<Edge>();
            foreach (var vertex in vertexes)
            {
                var incident = graph.GetIncidentEdges(vertex);
                foreach (var edge in incident)
                {
                    if (!edge.In(used) && !edge.In(edges))
                        edges.Add(edge);
                }
            }
            return edges;
        }

        private Edge MinWeightEdge(List<Edge> edges)
        {
            if (edges.Count == 0)
                return null;

            int min = 0;
            for (int i = 1; i < edges.Count; i++)
            {
                if (edges.ElementAt(min).GetWeight() > edges.ElementAt(i).GetWeight())
                    min = i;
            }
            return edges.ElementAt(min);
        }

        private Vertex GetExcludedTreeVertexByEdge(Edge edge)
        {
            return vertexes.IndexOf(edge.GetFirstVertex().GetNumber()) == -1 ? 
                edge.GetFirstVertex() : edge.GetSecondVertex();
        }

        private void Show()
        {
            ShowVertexes();
            ShowEdgesWeight();
        }

        private void ShowVertexes()
        {
            Console.WriteLine("Vertexes: ");
            foreach (var item in vertexes)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");
        }

        private void ShowEdgesWeight()
        {
            Console.WriteLine("Edges weights: ");
            foreach (var item in used)
            {
                Console.Write(item.GetWeight() + " ");
            }
            Console.Write("\n");
        }

    }
}
