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

namespace Match_Tracker
{
    public sealed partial class soccerTracker : Page
    {
        String team1Name;
        String team2Name;
        Int32 score1Goal = 0;
        Int32 score2Goal = 0;  

        public soccerTracker()
        {
            this.InitializeComponent();
            //sets names
            TeamNames();
        }

        private void teamOneName_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TeamOneName();
        }

        private void teamTwoName_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TeamTwoName();
        }
        private async void TeamOneName()
        {

            TextBox txtName = new TextBox();
            Grid contentGrid = new Grid();
            contentGrid.Children.Add(txtName);
            ContentDialog nameDialog = new ContentDialog()
            {
                Title = "Enter Team One Name",
                Content = contentGrid,
                PrimaryButtonText = "Submit"
            };

            await nameDialog.ShowAsync();

            if (txtName.Text != "")
            {
                team1Name = txtName.Text;
            }
            else
            {
                team1Name = "Team One";
            }

            teamOneName.Text = team1Name;


        }

        private async void TeamTwoName()
        {

            TextBox txtName = new TextBox();
            Grid contentGrid = new Grid();
            contentGrid.Children.Add(txtName);
            ContentDialog nameDialog = new ContentDialog()
            {
                Title = "Enter Team Two Name",
                Content = contentGrid,
                PrimaryButtonText = "Submit"
            };

            await nameDialog.ShowAsync();

            if (txtName.Text != "")
            {
                team2Name = txtName.Text;
            }
            else
            {
                team2Name = "Team Two";
            }

            teamTwoName.Text = team2Name;

        }

        private async void TeamNames()
        {
            StackPanel sp = new StackPanel();
            TextBox txtName1 = new TextBox();
            TextBox txtName2 = new TextBox();
            TextBlock txtLabel1 = new TextBlock();
            txtLabel1.Text = "Team One";
            TextBlock txtLabel2 = new TextBlock();
            txtLabel2.Text = "Team Two";
            sp.Children.Add(txtLabel1);
            sp.Children.Add(txtName1);
            sp.Children.Add(txtLabel2);
            sp.Children.Add(txtName2);

            ContentDialog nameDialog = new ContentDialog()
            {
                Title = "Enter Team Names",
                Content = sp,
                PrimaryButtonText = "Submit"
            };

            await nameDialog.ShowAsync();

            if (txtName1.Text != "")
            {
                team1Name = txtName1.Text;
            }
            else
            {
                team1Name = "Team One";
            }

            if (txtName2.Text != "")
            {
                team2Name = txtName2.Text;
            }
            else
            {
                team2Name = "Team Two";
            }

            //Update Names
            teamOneName.Text = team1Name;
            teamTwoName.Text = team2Name;

        }

        private void goalButton_Click(object sender, RoutedEventArgs e)
        {
            score1Goal++;
            goal1.Text = score1Goal.ToString();
        }

       

        private void goalButton2_Click(object sender, RoutedEventArgs e)
        {
            score2Goal++;
            goal2.Text = score2Goal.ToString();
        }

       

        private void goalRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (score1Goal > 0)
            {
                score1Goal--;
            }
            goal1.Text = score1Goal.ToString();
        }



        private void goal2RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (score2Goal > 0)
            {
                score2Goal--;
            }
            goal2.Text = score2Goal.ToString();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //save results
        }
    }
}
