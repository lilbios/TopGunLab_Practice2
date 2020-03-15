using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleApp
{
    public static class CountryGrouper
    {

        public static IEnumerable<object> GroupByValuta(IEnumerable<Country> countries)
        {
            var result = countries.GroupBy(v => v.Valuta)
                .Select(g => new
                {
                    Prop = g.Key,
                    Count = g.Count(),
                    Countries = g.Select(c => c.CountryName)

                });
            return result;

        }

        public static  IEnumerable<object> GroupByGeographicPole( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.GeograhicPole).Select(grp => grp.ToList()).ToList();

        }
        public static  IEnumerable<object> GroupBySideMove( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.SideMove).Select(grp => grp.ToList()).ToList();
        }
        public static IEnumerable<object> GroupByContinent( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => v.Continent).Select(grp => grp.ToList()).ToList();
        }
        public static  IEnumerable<object> GroupByAllProperty( IEnumerable<Country> countries)
        {
            return countries.GroupBy(v => new { v.Continent,v.GeograhicPole,v.SideMove,v.Valuta }).Select(grp => grp.ToList()).ToList();
        }
    }

}

