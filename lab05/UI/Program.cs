using lab05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {

            IGraph graph = new AdjacentMatrixGraph();

            graph.AddEdge(0, 1, 7);
            graph.AddEdge(1, 2, 8);
            graph.AddEdge(2, 3, 5);
            graph.AddEdge(3, 4, 9);
            graph.AddEdge(4, 5, 11);
            graph.AddEdge(5, 6, 6);
            graph.AddEdge(6, 0, 5);
            graph.AddEdge(6, 1, 9);
            graph.AddEdge(6, 3, 15);
            graph.AddEdge(5, 3, 8);
            graph.AddEdge(1, 3, 7);

            //graph.Print();

            new Prim().ShowTree(graph);

            Console.ReadLine();
        }

    }
}
