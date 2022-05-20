using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Basics
{
    public class GraphNode<T>
    {
        public T Value
        {
            get; set;
        }
        public GraphNode(T data)
        {
            Value = data;
            Edges = new List<GraphNode<T>>();
        }
        public List<GraphNode<T>> Edges
        {
            get; set;
        }
        public override string ToString()
        {
            var nodeString = new StringBuilder();
            nodeString.Append($"{Value} [ ");
            foreach (var item in Edges)
            {
                nodeString.Append(" => " + item.Value.ToString());
            }
            nodeString.AppendLine(" ]");
            return nodeString.ToString();
        }
    }
    internal class GraphDs<T>
    {
        public List<GraphNode<T>> Nodes
        {
            get; set;
        }
        public GraphDs()
        {
            Nodes = new List<GraphNode<T>>();
        }

        public GraphNode<T> Find(T val)
        {
            if (val is null)
            {
                return null;
            }
            return Nodes.FirstOrDefault(n => n.Value.Equals(val));
        }

        public bool AddNode(T val)
        {
            if (Find(val) is null)
            {
                var node = new GraphNode<T>(val);
                Nodes.Add(node);
                return true;
            }
            return false;
        }
        public bool AddEdge(T sourceNode, T targetNode)
        {
            var s = Find(sourceNode);
            var t = Find(targetNode);
            if (s is null || t is null || s.Edges.Contains(t))
            {
                return false;
            }
            s.Edges.Add(t);
            return true;
        }
        public bool RemoveNode(T val)
        {
            var target = Find(val);
            if (target is null)
                return false;
            target.Edges.Clear();// Not required
            Nodes.Remove(target);
            return true;
        }
        public bool RemoveEdge(T sourceNode, T targetNode)
        {
            var s = Find(sourceNode);
            var t = Find(targetNode);
            if (s is null || s.Edges is null)
                return false;
            s.Edges.Remove(t);
            return true;
        }
        public void Clear()
        {
            Nodes.Clear();
        }
        public override string ToString()
        {
            var graphString = new StringBuilder();
            foreach (var node in Nodes)
            {
                graphString.Append(node.ToString());
            }
            return graphString.ToString();
        }
        public void PrintGraph()
        {
            Console.WriteLine(ToString());
        }

        public void BFSTraversal(T rootVal)
        {
            var root = Find(rootVal);
            Queue<GraphNode<T>> path = new Queue<GraphNode<T>>();
            List<GraphNode<T>> visited = new List<GraphNode<T>>();
            path.Enqueue(root);
            visited.Add(root);
            while (path.Count > 0)
            {
                GraphNode<T> node = path.Dequeue();
                Console.Write(" => " + node.Value);
                foreach (var edge in node.Edges)
                {
                    if (visited.Contains(edge))
                    {
                        continue;
                    }
                    path.Enqueue(edge);
                    visited.Add(edge);
                }

            }
            Console.WriteLine();
        }
        public void DFSTraversal(T rootVal)
        {
            var root = Find(rootVal);
            Stack<GraphNode<T>> path = new Stack<GraphNode<T>>();
            List<GraphNode<T>> visited = new List<GraphNode<T>>();
            path.Push(root);
            visited.Add(root);
            while (path.Count > 0)
            {
                GraphNode<T> node = path.Pop();
                Console.Write(" => " + node.Value);
                foreach (var edge in node.Edges)
                {
                    if (visited.Contains(edge))
                    {
                        continue;
                    }
                    path.Push(edge);
                    visited.Add(edge);
                }
            }
            Console.WriteLine();
        }

    }
}
