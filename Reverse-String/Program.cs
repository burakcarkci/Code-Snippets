using System;

// Given an input string, reverse the string word by word.

namespace Exercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] inputString = "Hello my name is Jacob".Split(" ");

            string reversedString = "";

            for (int word = inputString.Length - 1; word >= 0; word--)
            {
                reversedString += inputString[word] + " ";
            }
            Console.WriteLine(reversedString);
        }
    }
}