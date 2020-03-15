using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Grouper
    {

        public static (List<int> even, List<int> odd) GroupNumbArray(int[] array)
        {
            if (array.Length == 0) throw new  ArgumentException("Empty array");
            var query =     
            from number in array
                group number by number % 2 == 0 into result
                select result;
            var oddNumbs = query.ElementAt(0).ToList(); 
            var evenNumbs = query.ElementAt(1).ToList();
            return (even:evenNumbs, odd: oddNumbs);


        }
    }
}
