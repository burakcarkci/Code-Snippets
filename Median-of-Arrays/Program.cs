using System;
using System.Collections.Generic;

// Find the median of two sorted arrays.
// arr1 = [1, 3, 5]
// arr2 = [2, 4, 6]
// median(arr1, arr2) = 3.5

namespace Exercises
{
    public class Median
    {
        public void MeadianValue(int[] arr1, int[] arr2)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                newList.Add(arr1[i]);
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                newList.Add(arr2[j]);
            }

            int[] arr3 = newList.ToArray();
			
			Array.Sort(nums3);

            int len = arr3.Length;

			//Find the value at position array[length / 2]
			//Find the value at postion array[length / 2 - 1]
			//Then sum up and divide by 2 (double)sum / 2
			//return 
			//Else return array[length / 2]
			
            if (len % 2 == 0)
            {
                int val1 = arr3[len / 2];
                int val2 = arr3[len / 2 - 1];
                int sum = val1 + val2;

                double even = (double)sum / 2;

                Console.WriteLine(even);
            }
            else
            {
				//Edge case if there is only 1 element in the array
                if (nums3.Length == 1)
                {
					Console.WriteLine(nums3[0]);
                }
                else
                {
                    int odd = nums3[len / 2];

					Console.WriteLine(odd);
                }
            }
        }
    }

    internal partial class Program
    {
        private static void Main(string[] args)
        {
            Median median = new Median();
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 5, 6, 8, 12 };
            median.MeadianValue(array1, array2);
        }
    }
}