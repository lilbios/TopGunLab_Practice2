using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using Task3.Third_part;

namespace ConsoleApp
{
    public delegate IEnumerable<object> GroupDelegate(IEnumerable<Country> countries);

    public static class CountryGrouper
    {

        public static IEnumerable<object> GroupByValuta(IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.Valuta)
               .Select(g => new
               {
                   Prop = g.Key,
                   Count = g.Count(),
                   Countries = g.Select(c => c.CountryName)

               });

        }

        public static IEnumerable<object> GroupByGeographicPole(IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.GeograhicPole).Select(g => new
            {
                Prop = g.Key,
                Countries = g.Select(c => new
                {
                    Name = c.CountryName,
                    PopulationDestiny = c.Area / c.Population
                })
            });
        }






        public static IEnumerable<object> GroupByContinent(IEnumerable<Country> countries)
        {
            var random = Singleton.GetInstance();
            return countries.GroupBy(v => v.Continent).Select(g => new
            {
                Prop = g.Key,
                Count = g.Count(),
                Countries = g.Select(c => new
                {
                    Name = c.CountryName,
                    Capital = c.Capital,
                    GPD = random.Next(500_000, 1_000_000_000) / c.Population
                }).OrderByDescending(param => param.GPD)

            })  ;
        }
        public static IEnumerable<object> GroupByAllProperty(IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => new { v.Continent, v.GeograhicPole, v.Valuta }).Select(g => new
            {

                Prop = g.Key,
                Countries = g.Select(c=> new { 
                        Name = c.CountryName,
                        Capital = c.Capital,
                        Population = c.Population,
                        Area = c.Area

                }).OrderBy(param=>param.Name)
            } ); 
        }
    }

}

