using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> factorial = Factorial.FuncFactorial;
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Output:{factorial(number)}");
        }
    }
}
