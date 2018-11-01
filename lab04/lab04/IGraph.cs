using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public interface IGraph
    {
        void AddVertex();

        void RemoveVertex(int vertexNumber);

        void AddEdge(int vertex1, int vertex2);
        
        void RemoveEdge(int vertex1, int vertex2);

        List<int[]> GetIncidentEdges(int vertexNumber);

        int[] GetAdjacentVertexes(int vertexNumber);

        int GetVertexesAmount();
    }
}
