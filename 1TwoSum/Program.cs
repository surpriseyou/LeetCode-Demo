using System;

namespace _1TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Sum.");

            var nums = new int[] { 3, 2, 4, 7, 1 };
            int target = 9;

            var arr = TwoSum(nums, target);
            System.Console.WriteLine($"[{arr[0]},{arr[1]}]");
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length && j != i; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        if (i > j)
                            return new int[] { j, i };
                        else
                            return new int[] { i, j };
                    }
                }
            }

            return null;
        }

    }
}
