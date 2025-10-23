using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valid_parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("(){}[]"));   
            Console.WriteLine(IsValid("(]"));       

        }

        public static bool IsValid(string p)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in p)
            {
                if(c== '(' || c=='[' || c=='{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Peek();

                    if ((c == ')' && top == '(') ||
                       (c == ']' && top == '[') ||
                       (c == '}' && top == '{'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
