using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Fibonacci
    {

        public static int GetFibNumberByIndex(int index) {
           return  Enumerable.Range(1, index)
            .Aggregate(new KeyValuePair<int, int>(0, 1), (seq, index) => new KeyValuePair<int, int>(seq.Value, seq.Key + seq.Value)).Value;
        }
    }
}
