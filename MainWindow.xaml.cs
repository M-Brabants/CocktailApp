using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace CocktailApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MyWindowLoaded;



        }




        private void MyWindowLoaded(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(new Home());
        }

        private void onClickHome(object sender, RoutedEventArgs e)
        {
            // == Keep Color on Click == \\

            /*var bc1 = new BrushConverter();
            Home.Background = (Brush)bc1.ConvertFrom("#FF2C2C2C");
            var bc2 = new BrushConverter();
            Discover.Background = (Brush)bc2.ConvertFrom("#FF333333");
            var bc3 = new BrushConverter();
            Saved.Background = (Brush)bc3.ConvertFrom("#FF333333");*/

            Frame.NavigationService.Navigate(new Home());
        }

        private void onClickDiscover(object sender, RoutedEventArgs e)
        {
            /*var bc1 = new BrushConverter();
            Home.Background = (Brush)bc1.ConvertFrom("#FF333333");
            var bc2 = new BrushConverter();
            Discover.Background = (Brush)bc2.ConvertFrom("#FF2C2C2C");
            var bc3 = new BrushConverter();
            Saved.Background = (Brush)bc3.ConvertFrom("#FF333333");*/

            Frame.NavigationService.Navigate(new Discover());
        }

        private void onClickSaved(object sender, RoutedEventArgs e)
        {
            /*var bc1 = new BrushConverter();
            Home.Background = (Brush)bc1.ConvertFrom("#FF333333");
            var bc2 = new BrushConverter();
            Discover.Background = (Brush)bc2.ConvertFrom("#FF333333");
            var bc3 = new BrushConverter();
            Saved.Background = (Brush)bc3.ConvertFrom("#FF2C2C2C");*/

            Frame.NavigationService.Navigate(new Saved());
        }
    }
}

