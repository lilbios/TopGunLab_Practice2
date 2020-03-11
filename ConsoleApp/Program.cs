using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            //Console.WriteLine(Task.Factorial(7));
            //var array = new []{ 1, 2, 3, 4,5,6,7,8,9,10 };
            //Console.WriteLine(Task.GroupIntArray(array));
            List<Country> countries = new List<Country>();
            countries.Add(new Country("England","London",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000,100_000_000),
                GeograhicPole.NORTH_EAST,Valuta.GPB,SideMove.LEFT,Continent.EUROPE));

            countries.Add(new Country("Geramny", "Berlin",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeograhicPole.WEST, Valuta.EUR, SideMove.RIGHT,Continent.EUROPE));

            countries.Add(new Country("France", "Paris",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeograhicPole.WEST, Valuta.EUR, SideMove.RIGHT, Continent.EUROPE));

            countries.Add(new Country("Spain", "Madrid",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeograhicPole.SOUTH_WEST, Valuta.EUR, SideMove.RIGHT, Continent.EUROPE));


            countries.Add(new Country("Australia", "Sydney",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeograhicPole.SOUTH_EAST, Valuta.USD, SideMove.LEFT, Continent.AUSTRALIA));

            countries.Add(new Country("USA", "Washington",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeograhicPole.WEST, Valuta.USD, SideMove.RIGHT, Continent.NORTH_AMERICA));

            countries.Add(new Country("Canada", "Ottawa",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeograhicPole.NORTH_WEST, Valuta.USD, SideMove.RIGHT, Continent.NORTH_AMERICA));

            countries.Add(new Country("Republic of South Africa", "Cape Town",
               random.Next(100_000_000, 900_000_000),
               random.Next(500_000, 100_000_000),
               GeograhicPole.SOUTH, Valuta.USD, SideMove.RIGHT, Continent.AFRICA));

            countries.Add(new Country("Japan", "Tokiyo",
               random.Next(100_000_000, 900_000_000),
               random.Next(500_000, 100_000_000),
               GeograhicPole.EAST, Valuta.JPY, SideMove.RIGHT, Continent.ASIA));

        }
    }
}
