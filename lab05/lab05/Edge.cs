using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Edge
    {

        private Vertex vertex1 = null;
        private Vertex vertex2 = null;
        private int weight;

        public Edge(int number1, int number2, int weight)
        {
            vertex1 = new Vertex(number1);
            vertex2 = new Vertex(number2);
            this.weight = weight;
        }

        public Vertex GetFirstVertex()
            => vertex1;

        public Vertex GetSecondVertex()
            => vertex2;

        public int GetWeight()
            => weight;

        public bool Equal(Edge edge)
        {
            var number1 = edge.GetFirstVertex().GetNumber();
            var number2 = edge.GetSecondVertex().GetNumber();
            return vertex1.GetNumber() == number1 && vertex2.GetNumber() == number2 
                || vertex2.GetNumber() == number1 && vertex1.GetNumber() == number2;
        }

        public bool In(List<Edge> edges)
        {
            foreach (var edge in edges)
            {
                if (this.Equal(edge))
                    return true;
            }
            return false;
        }

    }
}
