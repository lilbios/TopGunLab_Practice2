using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Factorial
    {
            public static int FuncFactorial(int bound)=> Enumerable.Range(1, bound).Aggregate((x, y) => x * y);
    }
}
