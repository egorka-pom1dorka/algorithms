using lab04;
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
            IGraph graph = new AdjacentListsGraph();

            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(1, 0);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(3, 2);
            //graph.AddEdge(3, 4);
            //graph.AddVertex();
            //graph.AddVertex();
            //graph.AddVertex();
            //graph.AddEdge(5, 7);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);

            //BFS.ShowBindingComponents(graph);

            BFS.ShowFractions(graph);

            //((IConsolePrintable)graph).Print();

            Console.ReadLine();
        }
    }
}
