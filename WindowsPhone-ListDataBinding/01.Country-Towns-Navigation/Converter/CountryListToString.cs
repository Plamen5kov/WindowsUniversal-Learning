using _01.Country_Towns_Navigation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace _01.Country_Towns_Navigation.Converter
{
    public class CountryListToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(targetType != typeof(string))
            {
                return null;
            }
            StringBuilder countryNames = new StringBuilder();
            var countries = value as ICollection<Country>;
            foreach (var country in countries)
            {
                countryNames.AppendLine(country.Name);
            }

            return countryNames.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
