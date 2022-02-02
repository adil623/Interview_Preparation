using System;

namespace LengthOfLastWord
{
    public class Solution
    {
        public static int LengthOfLastWord(string s)
        {
            string[] newStr = s.Trim().Split(' ');
            return newStr[newStr.Length - 1].Length;
        }
    }
}
