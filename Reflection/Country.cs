using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }


        public Country(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public string GetCountryInfo()
        {
            return "Country " + Name + " has the population of " + Population + ".";
        }
    }
}
