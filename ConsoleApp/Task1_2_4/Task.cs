using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{

    static class Task
    {
        
        public static int Factorial(int number) => Enumerable.Range(1, number).Aggregate((x, y) => x * y);

        public static int Fibonacci(int n) => Enumerable.Range(1, n)
            .Aggregate(new KeyValuePair<int, int>(0, 1), (seq, index) => new KeyValuePair<int, int>(seq.Value, seq.Key + seq.Value)).Value;


        public static void GroupIntArray(int[] array)
        {
         
            var strb = new StringBuilder();
            var query =
                from number in array
                group number by number % 2 == 0 into g
                select g;

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);
                foreach (var number in group)
                {
                    Console.WriteLine(number);
                }
            }
            
        }
    }
}
