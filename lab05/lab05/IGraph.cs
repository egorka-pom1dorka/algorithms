using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public interface IGraph
    {
        void AddVertex();

        void AddEdge(int vertex1, int vertex2, int weight);

        int GetVertexesAmount();

        Vertex GetVertexAt(int position);

        List<Edge> GetIncidentEdges(int vertexNumber);

        List<Vertex> GetAdjacentVertexes(int vertexNumber);

        void RemoveVertex(int vertexPosition);

        void RemoveEdge(int vertex1, int vertex2);

        void Print();

    }
}
