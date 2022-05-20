using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Basics
{
    internal class LinkedLists
    {
        public static void Basic()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(0);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
    public class NodeDs<N>
    {
        public NodeDs<N> Next;
        //NodeDs<N>? Prev;
        N Data;
        public NodeDs(N data)//, NodeDs<N> next)//, NodeDs<N>? pre = null)
        {
            Data = data;
            //Next = next;
            // Prev = pre;
        }
    }
    public class LinkedListDs<T>
    {
        public NodeDs<T> Head
        {
            get; set;
        }
        public NodeDs<T> AddNode(T data)
        {
            var node = new NodeDs<T>(data);
            if (Head == null)
            {
                Head = node;
            }
            var currentNode = Head;
            while (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = node;
            return node;
        }
    }
}
