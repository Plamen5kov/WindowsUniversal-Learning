using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Country_Towns_Navigation.ViewModels
{
    public class Town
    {
        public Town(string name, int population)
        {
            this.Name = name;
            this.Population = population;
        }
        public string Name { get; set; }

        public int Population { get; set; }

        public Country Country { get; set; }
    }
}
