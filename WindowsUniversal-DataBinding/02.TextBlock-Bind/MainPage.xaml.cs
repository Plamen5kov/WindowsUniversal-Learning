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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _02.TextBlock_Bind
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string[] Colors;
        public MainPage()
        {
            this.InitializeComponent();
            InitColors();
            this.comboBox_colors.DataContext = this.Colors;
        }

        private void InitColors()
        {
            this.Colors = new string[] { "Yellow", "Green", "Black", "Blue", "Orange", "Red", "Purple" };
        }
    }
}
