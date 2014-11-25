using _01.Country_Towns_Navigation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace _01.Country_Towns_Navigation.Converter
{
    public class TownsToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType != typeof(string))
            {
                return null;
            }

            StringBuilder result = new StringBuilder();
            var townsArr = value as ICollection<Town>;
            foreach (var town in townsArr)
            {
                result.AppendLine(town.Name);
            }

            return result.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
