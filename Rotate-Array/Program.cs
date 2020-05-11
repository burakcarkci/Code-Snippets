using System;

// Rotate an array of n elements to the left by k steps.
// Input: [1, 2, 3, 4, 5, 6, 7]
// Output: [4, 5, 6, 7, 1, 2, 3]

namespace Exercises
{
    public class RotateArray
    {
        public void LeftRotate(int[] array, int n, int k)
        {
            for (int i = 1; i < k; i++)
            {
                LeftRotateByOne(array, n);
            }
        }

        public void LeftRotateByOne(int[] array, int n)
        {
            int index;
            int tempArray = array[0];

            for (index = 0; index < n - 1; index++)
            {
                array[index] = array[index + 1];
            }
            array[index] = tempArray;
        }

        public void PrintArray(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            RotateArray rotateArray = new RotateArray();
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            rotateArray.LeftRotate(array, 7, 3);
            rotateArray.LeftRotateByOne(array, 7);
            rotateArray.PrintArray(array, 7);
        }
    }
}