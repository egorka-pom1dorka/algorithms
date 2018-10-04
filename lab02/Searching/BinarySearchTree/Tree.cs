using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree
    {

        public Node root = null;
        private int size = 0;
        
        public void Print()
        {
            PrintNode(root, size);
        }

        private void PrintNode(Node node, int depth)
        {
            if (node == null)
            {
                return;
            }

            var tabs = new String(' ', depth * 2);
            Console.Write(tabs + node.data);
            Console.WriteLine();

            PrintNode(node.left, depth - 1);
            PrintNode(node.right, depth - 1);
        }

        public Node Insert(int key)
        {
            size++;
            if (root == null)
            {
                root = new Node(key);
                return root;
            }
            return Insert(root, key);
        }

        public Node Insert(Node node, int key)
        {
            if (node == null)
            {
                return new Node(key);
            }

            if (node.data > key)
            {
                Node child = Insert(node.left, key);
                node.left = child;
                child.parent = node;
            }
            else
            {
                Node child = Insert(node.right, key);
                node.right = child;
                child.parent = node;
            }
            return node;
        }

        public Node Find(int key)
        {
            return Find(root, key);
        }

        private Node Find(Node node, int key)
        {
            if (node == null)
                return null;
            else if (key == node.data)
                return node;
            else if (key < node.data)
                return Find(node.left, key);
            else
                return Find(node.right, key);
        }

        public Node RotateRight(Node node)
        {
            if (node.left == null)
                return node;
            Node left = node.left;

            if (node.parent.left.data == node.data)
                node.parent.left = left;
            else
                node.parent.right = left;

            node.left = left.right;
            left.right = node;
            return left;
        }

        public Node RotateLeft(Node node)
        {
            if (node == null)
                return node;

            Node right = node.right;

            if (node.parent.left.data == node.data)
                node.parent.left = right;
            else
                node.parent.right = right;

            node.right = right.left;
            right.left = node;
            return right;
        }

    }
}
