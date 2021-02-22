using Course.Entities.Enums;
using Course.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static string isBalanced(string s) 
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else 
                {
                    if (stack.Count == 0)
                    {
                        return "NO";
                    }                    
                    else 
                    {
                        char pop_val = stack.Pop();
                        if (s[i] == ')' && pop_val != '(') 
                        {
                            return "NO";
                        }
                        else if (s[i] == '}' && pop_val != '{')
                        {
                            return "NO";
                        }
                        else if (s[i] == ']' && pop_val != '[')
                        {
                            return "NO";
                        }
                    }
                }
            }

            if (stack.Count == 0)
            {
                return "YES";
            }
            else { return "NO"; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isBalanced("{{[[(())]]}}"));
        }
    }
}
