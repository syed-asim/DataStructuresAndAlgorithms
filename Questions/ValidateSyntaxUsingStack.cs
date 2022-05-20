using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Questions
{
    internal class ValidateSyntaxUsingStack
    {
        public static Dictionary<char, char> RevereseParenthesis
        {
            get; set;
        }
        static ValidateSyntaxUsingStack ()
        {
            RevereseParenthesis = new Dictionary<char, char>();
            RevereseParenthesis['['] = ']';
            RevereseParenthesis['('] = ')';
            RevereseParenthesis['{'] = '}';
        }
        public static void Run(string expr)
        {
            Console.WriteLine("Expression is " + (isValidExpression(expr.ToCharArray()) ? "Valid" : "Invalid"));
        }

        private static bool isValidExpression(char[] exp)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var p in exp)
            {
                if (RevereseParenthesis.ContainsKey(p))
                {
                    stack.Push(p);
                }
                else if (stack.Count == 0 || RevereseParenthesis[stack.Pop()] != p)
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
