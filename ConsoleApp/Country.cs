using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Country
    {
        public string Capital { get; private set; }
        public int Population { get; private set; }
        public int Area { get; private set; }
        public GeograhicPole GeograhicPole { get; private set; }
        public Valuta Valuta { get; private set; }
        public SideMove SideMove { get; private set; }
        public Country(string capital, int population, int area,
            GeograhicPole geograhicPole, Valuta valuta, SideMove sideMove)
        {
            Capital = capital;
            Population = population;
            Area = area;
            GeograhicPole GeograhicPole = geograhicPole;
            Valuta Valuta = valuta;
            SideMove SideMove = sideMove;

        }
    }
}
