﻿using System;
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


        public static string GroupIntArray(int[] array)
        {
            int numberOfGroups = 0;
            var strb = new StringBuilder();
            var query =
                from number in array
                group number by number % 2 == 0 into g
                select g;

            strb.Append("Not Even numbers:");
            foreach (var group in query)
            {
                foreach (var number in group)
                {
                    strb.Append($" {number} ");
                }
                ++numberOfGroups;
                if (numberOfGroups != 2)
                {
                    strb.Append("\n");
                    strb.Append("Even numbers:");
                }
               
            }
            return strb.ToString();

        }
    }
}
