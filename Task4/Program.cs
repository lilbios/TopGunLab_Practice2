using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printFunc = number => Console.Write($" {number} ");
            var random = new Random();
            Console.WriteLine("Enter how many number you would like to generate:");
            int maxBoundary = Convert.ToInt32(Console.ReadLine());
            int[] numbers = Enumerable.Range(1, maxBoundary).ToArray();
            Console.Clear();
            var (even, odd) = Grouper.GroupNumbArray(numbers);
            Console.Write ("Even numbers:");
            even.ForEach(printFunc);
            Console.WriteLine();
            Console.Write("Odd numbers:");
            odd.ForEach(printFunc);

        }
    }
}
