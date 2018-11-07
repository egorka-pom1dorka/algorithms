using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    //public class AdjacentListsGraph : IGraph
    //{

    //    private List<int>[] lists = null;
    //    private int vertexesAmount = 0;

    //    private int MAX_GRAPH_VERTEX_AMOUNT = 100;

    //    public AdjacentListsGraph()
    //    {
    //        lists = new List<int>[MAX_GRAPH_VERTEX_AMOUNT];
    //    }

    //    public void AddVertex()
    //    {
    //        if (vertexesAmount + 1 > MAX_GRAPH_VERTEX_AMOUNT)
    //            throw new ArgumentOutOfRangeException("Graph is full");
            
    //        lists[vertexesAmount] = new List<int>();
    //        vertexesAmount++;
    //    }

    //    public void AddEdge(int vertex1, int vertex2)
    //    {
    //        if (lists[vertex1] == null || lists[vertex2] == null)
    //            throw new ArgumentException("There are no such vertexes");

    //        AddVertexInList(vertex1, vertex2);
    //        AddVertexInList(vertex2, vertex1);
    //    }

    //    private void AddVertexInList(int vertex, int adding)
    //    {
    //        if (lists[vertex].IndexOf(adding) == -1)
    //            lists[vertex].Add(adding);
    //    }

    //    public int GetVertexesAmount()
    //        => vertexesAmount;

    //    public Vertex GetVertexAt(int position)
    //    {
    //        return lists[position] == null ? null : new Vertex(position);
    //    }

    //    public Edge GetEdgeAt(int position)
    //    {
    //        if (lists[position] != null && lists[position + 1] != null)
    //            return new Edge(position, position + 1);
    //        return null;
    //    }

    //    public List<Vertex> GetAdjacentVertexes(int position)
    //    {
    //        var adjacent = new List<Vertex>();

    //        if (lists[position] == null)
    //            return adjacent;
            
    //        foreach (var number in lists[position])
    //            adjacent.Add(new Vertex(number));

    //        return adjacent;
    //    }

    //    public List<Edge> GetIncidentEdges(int position)
    //    {
    //        var incidents = new List<Edge>();
    //        foreach (var vertex in lists[position])
    //        {
    //            var edge = new Edge(position, vertex);
    //            incidents.Add(edge);
    //        }
    //        return incidents;
    //    }

    //    public void RemoveVertex(int position)
    //    {
    //        foreach (var list in lists)
    //        {
    //            if (list == null)
    //                break;

    //            if (list.IndexOf(position) != -1)
    //                list.RemoveAt(list.IndexOf(position));
    //        }

    //        lists[position] = null;
    //    }

    //    public void RemoveEdge(int position)
    //    {
    //        if (lists[position] != null)
    //            lists[position].RemoveAt(lists[position].IndexOf(position + 1));

    //        if (lists[position + 1] != null)
    //            lists[position + 1].RemoveAt(lists[position + 1].IndexOf(position));
    //    }

    //    public void Print()
    //    {
    //        int counter = 0;
    //        foreach (var list in lists)
    //        {
    //            if (list == null)
    //                break;
                
    //            PrintList(list, counter);
    //            Console.WriteLine();
    //            counter++;
    //        }
    //        Console.WriteLine();
    //    }

    //    private void PrintList(List<int> list, int index)
    //    {
    //        Console.Write($"{index}: ");
    //        foreach (var vertex in list)
    //            Console.Write(vertex + " ");
    //    }
        
    //}
}
