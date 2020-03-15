using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleApp
{
    public static class CountryGrouper
    {

        public static IEnumerable<object> GroupByValuta(List<Country> countries)
        {
            var result = countries.GroupBy(v => v.Valuta)
                .Select(g => new
                {
                    NameCounty = g.Key,

                }) ;
            return result;

        }

        public static  IEnumerable<IEnumerable<Country>> GroupByGeographicPole( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.GeograhicPole).Select(grp => grp.ToList()).ToList();

        }
        public static  IEnumerable<IEnumerable<Country>> GroupBySideMove( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.SideMove).Select(grp => grp.ToList()).ToList();
        }
        public static IEnumerable<IEnumerable<Country>> GroupByContinent( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.Continent).Select(grp => grp.ToList()).ToList();
        }
        public static  IEnumerable<IEnumerable<Country>> GroupByAllProperty( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => new { v.Continent,v.GeograhicPole,v.SideMove,v.Valuta }).Select(grp => grp.ToList()).ToList();
        }
    }

}

