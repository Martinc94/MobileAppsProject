using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


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

        private void seatButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(seatLocation));
        }

    }
}
