using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Match_Tracker
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void gaaButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GaaScore));
        }

        private void soccerButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(soccerTracker));
        }

        private void savedButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(results));
        }
    }
}
