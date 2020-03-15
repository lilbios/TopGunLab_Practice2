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
                Console.WriteLine($"Sign of sort: {item.Prop}");
                Console.WriteLine($"Countries: {item.Count}");
                foreach (var country in item.Countries)
                {
                    Console.WriteLine(country);
                }
                Console.WriteLine();
            }
            grouped = CountryGrouper.GroupByContinent(countries);
            foreach (var item in grouped)
            {
                Console.WriteLine($"Sign of sort: {item.Prop}");
                Console.WriteLine($"Countries: {item.Count}");
                foreach (var country in item.Countries)
                {
                    Console.WriteLine($"Сountry:{country.Name}");
                    Console.WriteLine($"Capital:{country.Capital}");
                    //ВВП на душу населения
                    Console.WriteLine($"GPD:{country.GPD}");
                }
                Console.WriteLine();
            }

        }
    }
}
