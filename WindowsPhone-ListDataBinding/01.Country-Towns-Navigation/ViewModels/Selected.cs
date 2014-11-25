using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Country_Towns_Navigation.ViewModels
{
    public class Selected : INotifyPropertyChanged
    {

        private string selectedCountry;

        public Selected()
        {
            this.SelectedCountry = "";
        }
        public string SelectedCountry 
        { 
            get
            {
                return this.selectedCountry;
            }
            set
            {
                this.selectedCountry = value;
                //NotifyIfChangedProperty();
                NotifyIfChangedProperty("SelectedCountry");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyIfChangedProperty([CallerMemberName]string propertyName = "")
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
