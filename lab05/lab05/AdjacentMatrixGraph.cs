using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class AdjacentMatrixGraph : IGraph
    {

        private int?[][] matrix;
        private int vertexesAmount;
        private int MAX_VERTEXES_AMOUNT = 10;

        public AdjacentMatrixGraph()
        {
            vertexesAmount = 0;
            matrix = new int?[MAX_VERTEXES_AMOUNT][];
            for (int i = 0; i < MAX_VERTEXES_AMOUNT; i++)
            {
                matrix[i] = new int?[MAX_VERTEXES_AMOUNT];

                for (int j = 0; j < MAX_VERTEXES_AMOUNT; j++)
                    matrix[i][j] = null;
            }
                
        }

        public void AddEdge(int vertex1, int vertex2, int weight)
        {
            AddInMatrix(vertex1, vertex2, weight);
            AddInMatrix(vertex2, vertex1, weight);
        }

        public void AddVertex()
        {
            AddInMatrix(vertexesAmount, vertexesAmount, 0);
        }

        private void AddInMatrix(int i, int j, int w)
        {
            if (vertexesAmount + 1 >= MAX_VERTEXES_AMOUNT)
                throw new Exception();

            if (matrix[i][i] == null)
                vertexesAmount++;

            if (matrix[j][j] == null)
                vertexesAmount++;

            for (int k = 0; k < vertexesAmount; k++)
            {
                if (matrix[k][i] == null)
                    matrix[k][i] = 0;
            }

            for (int k = 0; k < vertexesAmount; k++)
            {
                if (matrix[k][j] == null)
                    matrix[k][j] = 0;
            }

            matrix[i][j] = w;
        }

        public List<Vertex> GetAdjacentVertexes(int vertexNumber)
        {
            var adjacent = new List<Vertex>();
            for (int i = 0; i < MAX_VERTEXES_AMOUNT; i++)
            {
                if (matrix[vertexNumber][i] != null && i != vertexNumber)
                    adjacent.Add(new Vertex(i));
            }
            return adjacent;
        }

        public List<Edge> GetIncidentEdges(int vertexNumber)
        {
            var incident = new List<Edge>();
            for (int i = 0; i < MAX_VERTEXES_AMOUNT; i++)
            {
                if (matrix[vertexNumber][i] != null && i != vertexNumber)
                    incident.Add(new Edge(vertexNumber, i, (int)matrix[vertexNumber][i]));
            }
            return incident;
        }

        public Vertex GetVertexAt(int position)
        {
            return matrix[position][position] != null ? new Vertex((int)matrix[position][position]) : null;
        }

        public int GetVertexesAmount()
        {
            return vertexesAmount;
        }

        public void RemoveEdge(int vertex1, int vertex2)
        {
            matrix[vertex1][vertex2] = null;
            matrix[vertex2][vertex1] = null;
        }

        public void RemoveVertex(int position)
        {
            for (int i = 0; i < MAX_VERTEXES_AMOUNT; i++)
            {
                matrix[i][position] = null;
            }
            vertexesAmount--;
        }

        public void Print()
        {
            for (int i = 0; i < MAX_VERTEXES_AMOUNT; i++)
            {
                for (int j = 0; j < MAX_VERTEXES_AMOUNT; j++)
                {
                    if (matrix[i][j] != null)
                        Console.Write(matrix[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

    }
}
