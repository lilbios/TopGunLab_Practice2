using ConsoleApp;
using ConsoleApp.Task3;
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Initializer().Countries;
            dynamic grouped = CountryGrouper.GroupByValuta(countries);
            foreach (var item in grouped)
            {
                Console.WriteLine($"{item.Prop} {item.Count}");
                foreach (var country in item.Countries)
                {
                    Console.WriteLine(country);
                }
                Console.WriteLine();
            }
        }
    }
}
