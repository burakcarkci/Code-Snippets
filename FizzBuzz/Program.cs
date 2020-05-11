using System;

// Write a program that prints the numbers from 1 to 100 and for multiples of '3' print "Fizz" instead of the number and for the multiples of '5' print "Buzz".
// 1, 2, Fizz, 4, Buzz, Fizz...Buzz

namespace Exercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countFizz = 0;
            int countBuzz = 0;
            int countFizzBuzz = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz");
                    countFizzBuzz++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz");
                    countFizz++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz");
                    countBuzz++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Number of Fizz is " + countFizz);
            Console.WriteLine("Number of Buzz is " + countBuzz);
            Console.WriteLine("Number of FizzBuzz is " + countFizzBuzz);
        }
    }
}