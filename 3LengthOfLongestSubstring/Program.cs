using System;
using System.Runtime.InteropServices;

namespace _3LengthOfLongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str1 = "abcabcbb";
            Console.WriteLine(LengthOfLongestSubstring(str1));

            string str2 = "bbbbb";
            Console.WriteLine(LengthOfLongestSubstring(str2));

            string str3 = "pwwkew";
            Console.WriteLine(LengthOfLongestSubstring(str3));

            string str4 = " ";
            Console.WriteLine(LengthOfLongestSubstring(str4));

            string str5 = "";
            Console.WriteLine(LengthOfLongestSubstring(str5));

            string str6 = "dvdf";
            Console.WriteLine(LengthOfLongestSubstring(str6));

            string str7 = "aabaab!bb";
            Console.WriteLine(LengthOfLongestSubstring(str7));

            string str = "aab";
            Console.WriteLine(LengthOfLongestSubstring(str));
        }

        // todo: 性能有待提升
        public static int LengthOfLongestSubstring(string s)
        {
            string substr = string.Empty;
            int max = 0;
            foreach (var ch in s)
            {
                if (substr.Contains(ch))
                {
                    max = max > substr.Length ? max : substr.Length;
                    substr = substr.Substring(substr.IndexOf(ch) + 1);
                }
                substr += ch;
            }

            return max > substr.Length ? max : substr.Length;
        }
    }
}