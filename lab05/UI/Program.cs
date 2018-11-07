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

            graph.AddEdge(0, 1, 5);
            graph.AddEdge(0, 4, 3);
            graph.AddEdge(0, 3, 9);
            graph.AddEdge(1, 2, 6);
            graph.AddEdge(3, 2, 7);
            graph.AddEdge(2, 3, 8);

            graph.Print();

            Console.ReadLine();
        }
    }
}
