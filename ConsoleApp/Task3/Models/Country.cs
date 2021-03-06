﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Country
    {
        public string CountryName { get; private set; }
        public string Capital { get; private set; }
        public int Population { get; private set; }
        public int Area { get; private set; }
        public GeograhicPole GeograhicPole { get; private set; }
        public Valuta Valuta { get; private set; }
        public SideMove SideMove { get; private set; }
        public Continent Continent { get; private set; }
        public Country(string countryName, string capital, int population, int area,
            GeograhicPole geograhicPole, Valuta valuta, SideMove sideMove, Continent continent)
        {
            CountryName = countryName;
            Capital = capital;
            Population = population;
            Area = area;
            GeograhicPole = geograhicPole;
            Valuta = valuta;
            SideMove = sideMove;
            Continent = continent;

        }
    }
}
