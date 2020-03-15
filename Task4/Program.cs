using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> printFunc = number => Console.Write($" {number} ");
            var random = new Random();
        link:
            Console.WriteLine("Enter how many number you would like to generate:");
            int maxBoundary = Convert.ToInt32(Console.ReadLine());
            if (maxBoundary <= 0)
            {
                Console.WriteLine("Your number is not valid!Woudl you like try again?[y/N]:");
                var resopnse = Console.ReadLine();
                if (resopnse == "y")
                {
                    Console.Clear();
                    goto link;
                }
            }
            else
            {

                int[] numbers = Enumerable.Range(1, maxBoundary).ToArray();
                Console.Clear();
                var (even, odd) = Grouper.GroupNumbArray(numbers);
                Console.Write("Even numbers:");
                even.ForEach(printFunc);
                Console.WriteLine();
                Console.Write("Odd numbers:");
                odd.ForEach(printFunc);
            }



        }
    }
}
