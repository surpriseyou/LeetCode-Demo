using System;
using System.Linq;
using System.Text;

namespace _557ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "Let's take LeetCode contest";
            Console.WriteLine(ReverseWords(str));
        }


        public static string ReverseWords(string s)
        {
            var arr = s.Split(' ');


            string reserve(string str)
            {
                char[] arr = new char[str.Length];
                for (int i = 0; i < str.Length / 2; i++)
                {
                    arr[i] = str[str.Length - i - 1];
                    arr[str.Length - i - 1] = str[i];
                }
                if (str.Length % 2 == 1)
                {
                    arr[(str.Length / 2)] = str[(str.Length / 2)];
                }
                return new string(arr);
            };


            //StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                //sb.Append(reserve(arr[i]));
                //sb.Append(" ");
                arr[i] = reserve(arr[i]);
            }
            return string.Join(" ", arr);
        }
    }
}
