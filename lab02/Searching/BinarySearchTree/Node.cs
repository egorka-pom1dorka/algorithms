using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {

        public int data;
        public Node left = null;
        public Node right = null;
        public Node parent = null;

        public Node(int data) {
            this.data = data;
        }

    }
}
