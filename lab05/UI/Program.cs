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

            while (true)
            {
                Step(graph);
            }

            //graph.AddEdge(0, 1, 7);
            //graph.AddEdge(1, 2, 8);
            //graph.AddEdge(2, 3, 5);
            //graph.AddEdge(3, 4, 9);
            //graph.AddEdge(4, 5, 11);
            //graph.AddEdge(5, 6, 6);
            //graph.AddEdge(6, 0, 5);
            //graph.AddEdge(6, 1, 9);
            //graph.AddEdge(6, 3, 15);
            //graph.AddEdge(5, 3, 8);
            //graph.AddEdge(1, 3, 7);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1 - create new graph");
            Console.WriteLine("2 - add vertex");
            Console.WriteLine("3 - add edge");
            Console.WriteLine("4 - show graph");
            Console.WriteLine("5 - Prim");
        }

        private static int GetInt()
        {
            string input = Console.ReadLine();
            int number;
            int.TryParse(input, out number);
            return number;
        }

        private static void Step(IGraph graph)
        {
            ShowMenu();
            int item = GetInt();

            switch (item)
            {
                case 1:
                    graph = new AdjacentMatrixGraph();
                    break;

                case 2:
                    Console.WriteLine("Input vertex");
                    graph.AddVertex();
                    break;

                case 3:
                    Console.WriteLine("Input edge's vertex");
                    int vertex1 = GetInt();

                    Console.WriteLine("Input edge's another vertex");
                    int vertex2 = GetInt();

                    Console.WriteLine("Input edge's weight");
                    int weight = GetInt();
                    graph.AddEdge(vertex1, vertex2, weight);
                    break;

                case 4:
                    graph.Print();
                    break;

                case 5:
                    new Prim().ShowTree(graph);
                    break;

                default:
                    Step(graph);
                    break;
            }

            Console.WriteLine();
        }

    }
}
