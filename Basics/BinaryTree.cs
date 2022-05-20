using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Basics
{
    internal class BinaryTree
    {
        public BinaryNode Root
        {
            get; set;
        }
        public BinaryTree(BinaryNode root)
        {
            Root = root;
        }
        public void BFSTraversal()
        {
            Queue<BinaryNode> path = new Queue<BinaryNode>();
            path.Enqueue(Root);
            while (path.Count > 0)
            {
                BinaryNode node = path.Dequeue();
                Console.Write(" => " + node.Data);
                if (node.Left is not null)
                {
                    path.Enqueue(node.Left);
                }
                if (node.Right is not null)
                {
                    path.Enqueue(node.Right);
                }
            }
            Console.WriteLine();
        }
        public void BFSSearch(string search)
        {
            Console.WriteLine("Searching for node: " + search);
            Queue<BinaryNode> path = new Queue<BinaryNode>();
            path.Enqueue(Root);
            while (path.Count > 0)
            {
                BinaryNode node = path.Dequeue();
                if (node.Data == search)
                {
                    Console.WriteLine(" Result found! " + node.Data);
                    break;
                }
                else
                    Console.Write(" searching => " + node.Data);
                if (node.Left is not null)
                {
                    path.Enqueue(node.Left);
                }
                if (node.Right is not null)
                {
                    path.Enqueue(node.Right);
                }
            }
        }

        public void DFSTraversal(BinaryNode root)
        {
            if (root is null)
            {
                return;
            }
            Console.Write(" => " + root.Data);
            DFSTraversal(root.Left);
            DFSTraversal(root.Right);
        }
    }
    public class BinaryNode
    {
        public BinaryNode Left
        {
            get; set;
        }
        public BinaryNode Right
        {
            get; set;
        }
        public string Data
        {
            get; set;
        }
        public BinaryNode(string data, BinaryNode left, BinaryNode right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public BinaryNode(string data)
        {
            Data = data;
        }
    }
}
