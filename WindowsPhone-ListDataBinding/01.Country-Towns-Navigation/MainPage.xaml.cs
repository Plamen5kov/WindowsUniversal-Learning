using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using _01.Country_Towns_Navigation.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _01.Country_Towns_Navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Selected selected;

        public MainPage()
        {
            this.Towns = new List<Town>();
            this.Countries = new List<Country>();

            this.InitializeComponent();
            this.InitializeData();

            this.selected = new Selected();

            this.tb_countries.DataContext = this.Countries;
            this.tb_towns.DataContext = this.Towns;
            //this.tb_towns.DataContext = this.selected;

            //this.BindSelectedText();
        }

        public ICollection<Town> Towns { get; set; }
        public ICollection<Country> Countries { get; set; }


        //private void BindSelectedText()
        //{
        //    Binding myBinding = new Binding();
        //    myBinding.Source = this.selected;
        //    this.tb_countries.SetBinding(TextBlock.TextProperty, myBinding);
        //}

        private void InitializeData()
        {
            var bulgaria = new Country("Bulgaria", "bulgarian", "Pics/flag-bg.jpg");

            var sofiq = new Town("Sofiq", 121235);
            var plovdiv = new Town("Plovdiv", 155213);
            var burgas = new Town("Burgas", 1552213);
            sofiq.Country = bulgaria;
            plovdiv.Country = bulgaria;
            burgas.Country = bulgaria;

            bulgaria.Towns.Add(sofiq);
            bulgaria.Towns.Add(plovdiv);
            bulgaria.Towns.Add(burgas);
            this.Countries.Add(bulgaria);

            var germany = new Country("Germany", "deutch", "Pics/flag-de.jpg");
            var essen = new Town("Essen", 121235);
            var cologne = new Town("Cologne", 155213);
            var bonn = new Town("Bonn", 1552213);
            essen.Country = germany;
            cologne.Country = germany;
            bonn.Country = germany;

            germany.Towns.Add(essen);
            germany.Towns.Add(cologne);
            germany.Towns.Add(bonn);
            this.Countries.Add(germany);

            var russia = new Country("Russia", "russian", "Pics/flag-ru.jpg");
            var minsk = new Town("Minsk", 121235);
            var nijniNovgrod = new Town("Nijni Novgrod", 155213);
            var moskva = new Town("Moskva", 1552213);
            essen.Country = russia;
            cologne.Country = russia;
            bonn.Country = russia;

            russia.Towns.Add(minsk);
            russia.Towns.Add(nijniNovgrod);
            russia.Towns.Add(moskva);
            this.Countries.Add(russia);
        }

        private void tb_towns_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var country in this.Countries)
            {
                if (country.Name == this.textBlock_countryLabel.Text)
                {
                    this.tb_towns.DataContext = country.Towns;
                    break;
                }
            }
        }
    }
}
