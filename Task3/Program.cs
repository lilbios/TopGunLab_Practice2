using ConsoleApp;
using ConsoleApp.Task3;
using System;
using System.Collections.Generic;
using Task3.UI;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();

            var groupDelegate = new GroupDelegate(CountryGrouper.GroupByValuta);
            var page = new Page("Valuta", groupDelegate);

            menu.AddPage(page);



            groupDelegate = new GroupDelegate(CountryGrouper.GroupByContinent);
            page = new Page("Continent", groupDelegate);
            menu.AddPage(page);


            groupDelegate = new GroupDelegate(CountryGrouper.GroupByGeographicPole);
            page = new Page("Geographic Pole", groupDelegate);
            menu.AddPage(page);

            groupDelegate = new GroupDelegate(CountryGrouper.GroupByAllProperty);
            page = new Page("All properties", groupDelegate);
            menu.AddPage(page);

            menu.DrawMenu();





        }
    }
}
