using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Vertex
    {
        private int vertexNumber;

        public Vertex(int number)
        {
            vertexNumber = number;
        }

        public int GetNumber()
            => vertexNumber;
    }
}
