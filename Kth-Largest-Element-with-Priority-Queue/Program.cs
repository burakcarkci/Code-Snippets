using System;

namespace Exercises
{
    internal partial class Program
    {
        private static void Main(string[] args)
        {
            PriorityQueue priorityQueue = new PriorityQueue(7);
            priorityQueue.Add(1);
            priorityQueue.Add(2);
            priorityQueue.Add(3);
            priorityQueue.Add(4);
            priorityQueue.Add(5);
            priorityQueue.Add(5);
            priorityQueue.Add(7);

            int result = priorityQueue.FindKthLargestElement(5);

            Console.WriteLine(result);
        }
    }
}