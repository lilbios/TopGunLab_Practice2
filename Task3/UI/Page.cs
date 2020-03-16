using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.UI
{
    class Page
    {
        public string Title { get; set; }
        public  GroupDelegate GroupHandler { get;private set; }

        public Page(string title, GroupDelegate groupFunc)
        {
            Title = title;
            GroupHandler = groupFunc;
        }
        public void Click(IEnumerable<Country> countries) {

            Console.Clear();
            dynamic grouped = GroupHandler(countries);
            switch (Title)
            {

                case "Valuta":
                    foreach (var item in grouped)
                    {
                        Console.WriteLine($" #{item.Prop}# ");
                        Console.WriteLine($"Countries: {item.Count}");
                        foreach (var country in item.Countries)
                        {
                            Console.WriteLine(country);
                        }
                        Console.WriteLine();
                    }
                    break;
                case "Continent":
                    foreach (var item in grouped)
                    {
                        Console.WriteLine($" *{item.Prop}* ");
                        Console.WriteLine($"Count: {item.Count}");
                        foreach (var country in item.Countries)
                        {

                            Console.WriteLine($"Сountry:{country.Name}");
                            Console.WriteLine($"Capital:{country.Capital}");
                            //ВВП на душу населения
                            Console.WriteLine($"GPD:{country.GPD}");
                            Console.WriteLine(new string('_', 30));

                        }
                        Console.WriteLine();
                    }
                    break;

                case "Geographic Pole":
                    foreach (var item in grouped)
                    {
                        Console.WriteLine($" ~{item.Prop}~ ");
                        foreach (var country in item.Countries)
                        {
                            Console.WriteLine($"Сountry:{country.Name}");
                            Console.WriteLine($"Population destination:{country.PopulationDestiny}");
                        }
                    }
                    break;
                case "All properties":
                    foreach (var item in grouped)
                    {
                        Console.WriteLine($" ${item.Prop}$ ");
                        foreach (var country in item.Countries)
                        {
                            Console.WriteLine($"Сountry: {country.Name}");
                            Console.WriteLine($"Capital: {country.Capital}");
                            Console.WriteLine($"Population: {country.Population} bil.");
                            Console.WriteLine($"Area: {country.Area} km^2");
                        }
                    }
                    break;

                default:
                    break;
            }


            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Back");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
