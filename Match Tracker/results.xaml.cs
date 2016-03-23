using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Match_Tracker
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class results : Page
    {
        public results()
        {
            this.InitializeComponent();
        }

        private void gaaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GaaResults));
        }

        private void soccerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SoccerResults));
        }

        private void savedButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
