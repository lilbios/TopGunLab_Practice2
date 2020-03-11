using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp
{
    public static class CountryGrouper
    {

        public static IEnumerable<Country> GroupByValuta(IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.Valuta).Select(grp=> grp.ToList()).ToList() as IEnumerable<Country>;


        }

        public static IEnumerable<Country> GroupByGeographicPole(IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.GeograhicPole).Select(grp => grp.ToList()).ToList() as IEnumerable<Country>;
        }
        public static IEnumerable<Country> GroupBySideMode(IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.SideMove).Select(grp => grp.ToList()).ToList() as IEnumerable<Country>;
        }
        public static IEnumerable<Country> GroupByContinent(IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.Continent).Select(grp => grp.ToList()).ToList() as IEnumerable<Country>;
        }


    }
}
