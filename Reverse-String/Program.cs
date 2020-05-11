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

            for (int word = myString.Length - 1; word >= 0; word--)
            {
                reversedString += myString[word] + " ";
            }
            Console.WriteLine(reversedString);
        }
    }
}