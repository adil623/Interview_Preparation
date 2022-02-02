using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidParenthisis
{
    public class Solution
    {
        public static bool IsValid(string s)
        {
            bool flag = false;
            char[] str = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int parenthis = 0; parenthis < str.Length; parenthis++)
            {
                if (str[parenthis] == '(' || str[parenthis] == '{' || str[parenthis] == '[')
                {
                    stack.Push(str[parenthis]);
                    if (parenthis == str.Length - 1)
                    {
                        flag = false;
                    }
                }
                else if (str[parenthis] == ')' || str[parenthis] == '}' || str[parenthis] == ']')
                {
                    if (stack.Any())
                    {
                        if (str[parenthis] == ')' && stack.Pop() == '(')
                        {
                            flag = true;
                        }
                        else if (str[parenthis] == '}' && stack.Pop() == '{')
                        {
                            flag = true;
                        }
                        else if (str[parenthis] == ']' && stack.Pop() == '[')
                        {
                            flag = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            if (stack.Any())
            {
                flag = false;
            }
            return flag;
        }
    }
}
