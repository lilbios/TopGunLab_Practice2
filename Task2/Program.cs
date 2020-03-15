using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> fibonacci = Fibonacci.GetFibNumberByIndex;
            Console.WriteLine("Enter index of number in fibonacci sequence:");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output:{fibonacci(position)}");
        }
    }
}
