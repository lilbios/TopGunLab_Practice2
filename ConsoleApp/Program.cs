using ConsoleApp.Task3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var countries = new Initializer().Countries;
            var grouped = CountryGrouper.GroupByAllProperty(countries);
            var range = Enumerable.Range(1, 10).ToArray();
            

           
        }
        
    }
}
