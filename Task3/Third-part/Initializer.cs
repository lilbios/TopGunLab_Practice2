using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Task3
{
    public class Initializer
    {
        public List<Country> Countries { get; private set; }
        public Initializer()
        {
            var random = new Random();
            Countries = new List<Country>();
            Countries.Add(new Country("England", "London",
               random.Next(100_000_000, 900_000_000),
               random.Next(500_000, 100_000_000),
               GeographicPole.NORTH_EAST, Valuta.GPB, SideMove.LEFT, Continent.EUROPE));

            Countries.Add(new Country("Geramny", "Berlin",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeographicPole.WEST, Valuta.EUR, SideMove.RIGHT, Continent.EUROPE));

            Countries.Add(new Country("France", "Paris",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeographicPole.WEST, Valuta.EUR, SideMove.RIGHT, Continent.EUROPE));

            Countries.Add(new Country("Spain", "Madrid",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeographicPole.SOUTH_WEST, Valuta.EUR, SideMove.RIGHT, Continent.EUROPE));


            Countries.Add(new Country("Australia", "Sydney",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeographicPole.SOUTH_EAST, Valuta.USD, SideMove.LEFT, Continent.AUSTRALIA));

            Countries.Add(new Country("USA", "Washington",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeographicPole.WEST, Valuta.USD, SideMove.RIGHT, Continent.NORTH_AMERICA));

            Countries.Add(new Country("Canada", "Ottawa",
                random.Next(100_000_000, 900_000_000),
                random.Next(500_000, 100_000_000),
                GeographicPole.NORTH_WEST, Valuta.USD, SideMove.RIGHT, Continent.NORTH_AMERICA));

            Countries.Add(new Country("Republic of South Africa", "Cape Town",
               random.Next(100_000_000, 900_000_000),
               random.Next(500_000, 100_000_000),
               GeographicPole.SOUTH, Valuta.USD, SideMove.RIGHT, Continent.AFRICA));

            Countries.Add(new Country("Japan", "Tokiyo",
               random.Next(100_000_000, 900_000_000),
               random.Next(500_000, 100_000_000),
               GeographicPole.EAST, Valuta.JPY, SideMove.RIGHT, Continent.ASIA));

        }
    }
}
