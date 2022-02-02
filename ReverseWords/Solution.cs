using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseWords
{
    public class Solution
    {
        public static string ReverseWords(string s)
        {
            string[] words = string.Join(" ", s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).ToList().Select(x => x.Trim())).Split();
            StringBuilder reverseString = new StringBuilder();
            Stack<string> stack = new Stack<string>();
            foreach (var word in words)
            {
                stack.Push(word);
            }
            while (stack.Any())
            {
                reverseString.Append(stack.Pop() + " ");
            }

            return reverseString.ToString().Trim();
        }
    }
}
