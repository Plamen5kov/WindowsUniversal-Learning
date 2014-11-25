using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace _01.Country_Towns_Navigation.Helpers
{
    public class AttachedProperties
    {
        private static DependencyProperty SelectedTextProperty =
            DependencyProperty.RegisterAttached("SelectedText", typeof(string),
                typeof(AttachedProperties), new PropertyMetadata(default(string), OnSelectedTextChanged));

        private static void OnSelectedTextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var txtBox = d as TextBox;
            if (txtBox == null)
                return;

            txtBox.SelectedText = e.NewValue.ToString();
        }

        public static string GetSelectedText(DependencyObject dp)
        {
            if (dp == null) throw new ArgumentNullException("dp");

            return (string)dp.GetValue(SelectedTextProperty);
        }

        public static void SetSelectedText(DependencyObject dp, object value)
        {
            if (dp == null) throw new ArgumentNullException("dp");

            dp.SetValue(SelectedTextProperty, value);
        }
    }
}
