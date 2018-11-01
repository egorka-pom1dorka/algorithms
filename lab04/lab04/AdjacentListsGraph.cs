using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class AdjacentListsGraph : IGraph, IConsolePrintable
    {

        private List<int>[] lists = null;
        private int currentGraphSize = 0;

        private int MAX_GRAPH_VERTEX_AMOUNT = 100;

        public List<int>[] GetLists()
            => lists;

        public int GetVertexesAmount()
            => currentGraphSize;

        public AdjacentListsGraph()
        {
            lists = new List<int>[MAX_GRAPH_VERTEX_AMOUNT];
        }

        public void AddVertex()
        {
            CreateVertexIfNecessary(currentGraphSize);
        }

        private void CreateVertexIfNecessary(int vertexNumber)
        {
            if (lists[vertexNumber] == null)
            {
                lists[vertexNumber] = new List<int>();
                currentGraphSize++;
            }
        }

        public void AddEdge(int vertex1, int vertex2)
        {
            CreateVertexIfNecessary(vertex1);
            CreateVertexIfNecessary(vertex2);

            AddVertexInList(vertex1, vertex2);
            AddVertexInList(vertex2, vertex1);
        }

        private void AddVertexInList(int vertex, int adding)
        {
            if (lists[vertex].IndexOf(adding) == -1)
                lists[vertex].Add(adding);
        }

        public int[] GetAdjacentVertexes(int vertexNumber)
        {
            if (lists[vertexNumber] == null)
                return new int[0];

            int[] adjacent = new int[lists[vertexNumber].Count];
            int counter = 0;

            foreach (var vertex in lists[vertexNumber])
            {
                adjacent[counter++] = vertex;
            }

            return adjacent;
        }

        public List<int[]> GetIncidentEdges(int vertexNumber)
        {
            List<int[]> incidents = new List<int[]>();

            foreach (var vertex in lists[vertexNumber])
            {
                incidents.Add(new int[] { vertexNumber, vertex });
            }

            return incidents;
        }

        public void RemoveEdge(int vertex1, int vertex2)
        {
            if (lists[vertex1] != null)
                lists[vertex1].RemoveAt(lists[vertex1].IndexOf(vertex2));

            if (lists[vertex2] != null)
                lists[vertex2].RemoveAt(lists[vertex2].IndexOf(vertex1));
        }

        public void RemoveVertex(int vertexNumber)
        {
            foreach (var list in lists)
            {
                if (list != null && list.IndexOf(vertexNumber) != -1)
                {
                    list.RemoveAt(list.IndexOf(vertexNumber));
                }
            }

            lists[vertexNumber] = null;
        }

        public void Print()
        {
            int counter = 0;
            foreach (var list in lists)
            {
                if (list != null)
                {
                    PrintList(list, counter);
                    Console.WriteLine();
                }
                counter++;
            }
            Console.WriteLine();
        }

        private void PrintList(List<int> list, int index)
        {
            Console.Write($"{index}: ");
            foreach (var vertex in list)
            {
                Console.Write(vertex + " ");
            }
        }
    }
}
