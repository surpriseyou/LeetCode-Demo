using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;

namespace _4FindMedianSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Console.WriteLine((double) 5 / 2);
            int[] nums1 = new int[] {1, 3, 5, 7};
            int[] nums2 = new int[] {2, 4};
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
            Console.WriteLine(FindMedianSortedArrays2(nums1, nums2));
        }


        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0.0;
            if (nums1 != null && nums2 != null)
            {
                List<int> list = new List<int>(nums1);
                list.AddRange(nums2);
                if (list.Count > 0)
                {
                    var array = list.OrderBy(t => t).ToArray();
                    if (array.Length % 2 == 0)
                    {
                        int mid = array.Length / 2;
                        //mid = mid == 0 ? 1 : mid;
                        median = (double) (array[mid - 1] + array[mid]) / 2;
                    }
                    else
                    {
                        median = (double) array[array.Length / 2];
                    }
                }
            }


            return median;
        }

        public static double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            double median = 0.0;
            if (nums1 != null && nums2 != null)
            {
                int bindex = 0;
                int aindex = 0;
                int total = nums1.Length + nums2.Length;
                int mid = (total / 2) + (total % 2);
                int[] arr = new int[total];
                int i = 0;
                int temp = 0;
                while (i <= mid)
                {
                    if (aindex < nums1.Length && bindex < nums2.Length)
                    {
                        if (nums1[aindex] <= nums2[bindex])
                        {
                            if (mid % 2 == 0)
                            {
                                
                            }
                            else
                            {
                                
                            }

                            median = nums1[aindex];
                            aindex++;
                        }
                        else
                        {
                            median = nums2[bindex];
                            bindex++;
                        }
                    }
                    
                    
                    if (aindex == nums1.Length)
                    {
                       
                    }
                    else if (bindex == nums2.Length)
                    {
                        aindex++;
                    }

                   

                    i++;
                }
            }

            return median;
        }
    }
}