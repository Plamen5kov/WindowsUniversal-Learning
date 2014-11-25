using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Country_Towns_Navigation.ViewModels
{
    public class Country
    {
        public Country(string name, string language, string nationalFlag)
        {
            this.Name = name;
            this.Language = language;
            this.NationalFlag = nationalFlag;

            this.Towns = new List<Town>();
        }

        public string Name { get; set; }

        public string Language { get; set; }

        public string NationalFlag { get; set; }

        public ICollection<Town> Towns { get; set; }
    }
}
