using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class BFS
    {

        public static void ShowBindingComponents(IGraph graph)
        {
            string alphbet = "ABCDEFGHIKLMNOPQRSTVXYZ";
            int vertexesAmount = graph.GetVertexesAmount();
            int marksAmount = 0;
            int initialVertex = 0;
            int componentName = 0;

            bool[] passed = new bool[vertexesAmount];
            for (int i = 0; i < vertexesAmount; i++)
            {
                passed[i] = false;
            }

            while (marksAmount < vertexesAmount)
            {
                int?[] marks = GetMarks(graph, initialVertex);

                PrintComponent(marks, alphbet.ElementAt(componentName));

                marksAmount += GetMarkedVertexesAmount(marks);

                FillPassed(marks, passed);
                initialVertex = GetFreeVertex(passed);

                componentName++;
            }
        }

        private static int?[] GetMarks(IGraph graph, int initialVertex)
        {
            Queue<int> rest = new Queue<int>();
            int?[] marks = new int?[graph.GetVertexesAmount()];

            int mark = 1;
            marks[initialVertex] = mark;
            mark++;

            int[] initialVertexes = graph.GetAdjacentVertexes(initialVertex);

            foreach (var vertex in initialVertexes)
            {
                marks[vertex] = mark;
                rest.Enqueue(vertex);
            }

            mark++;

            while (rest.Count!= 0)
            {
                int currentVertex = rest.Dequeue();
                initialVertexes = graph.GetAdjacentVertexes(currentVertex);

                foreach (var vertex in initialVertexes)
                {
                    if (marks[vertex] == null) {
                        rest.Enqueue(vertex);
                        marks[vertex] = mark;
                    }
                }
                mark = (int)marks[currentVertex] + 1;
            }

            return marks;
        }

        private static int GetMarkedVertexesAmount(int?[] marks)
        {
            int amount = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] != null)
                    amount++;
            }
            return amount;
        }

        private static void PrintComponent(int?[] marks, char component)
        {
            Console.WriteLine($"{component}: ");
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] != null)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void FillPassed(int?[] marks, bool[] passed)
        {
            for (int i = 0; i < passed.Length; i++)
            {
                if (marks[i] != null)
                {
                    passed[i] = true;
                }
            }
        }

        private static int GetFreeVertex(bool[] passed)
        {
            for (int i = 0; i < passed.Length; i++)
            {
                if (passed[i] == false)
                    return i;
            }

            return -1;
        }

        public static void ShowFractions(IGraph graph)
        {
            try
            {
                var marks = GetFractionsMarks(graph, 0);
                
                if (GetMarkedVertexesAmount(marks) != graph.GetVertexesAmount())
                {
                    Console.WriteLine("Graph is not dicotyledonous!");
                    return;
                }

                List<int> fraction1 = new List<int>();
                List<int> fraction2 = new List<int>();

                for (int i = 0; i < marks.Length; i++)
                {
                    if (marks[i] % 2 == 0)
                        fraction1.Add(i);
                    else
                        fraction2.Add(i);
                }

                Console.WriteLine("Fraction 1: ");
                foreach (var vertex in fraction1)
                {
                    Console.Write(vertex + " ");
                }

                Console.WriteLine();

                Console.WriteLine("Fraction 2: ");
                foreach (var vertex in fraction2)
                {
                    Console.Write(vertex + " ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static int?[] GetFractionsMarks(IGraph graph, int initialVertex)
        {
            Queue<int> rest = new Queue<int>();
            int?[] marks = new int?[graph.GetVertexesAmount()];

            int mark = 1;
            marks[initialVertex] = mark;
            mark++;

            int[] initialVertexes = graph.GetAdjacentVertexes(initialVertex);

            foreach (var vertex in initialVertexes)
            {
                marks[vertex] = mark;
                rest.Enqueue(vertex);
            }

            mark++;

            while (rest.Count != 0)
            {
                int currentVertex = rest.Dequeue();
                initialVertexes = graph.GetAdjacentVertexes(currentVertex);

                foreach (var vertex in initialVertexes)
                {
                    if (marks[vertex] == null)
                    {
                        rest.Enqueue(vertex);
                        marks[vertex] = mark;
                    } else if (marks[vertex] % 2 == mark)
                    {
                        throw new Exception("Graph is not dicotyledonous");
                    }
                }
                mark = (int)marks[currentVertex] + 1;
            }

            return marks;
        }

    }
}
