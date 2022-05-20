using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Basics
{
    internal class StackDs
    {
        public static void Run()
        {
            Stack<int> stack=new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}
