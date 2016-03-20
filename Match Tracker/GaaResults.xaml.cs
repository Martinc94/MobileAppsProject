using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Match_Tracker
{
    public sealed partial class GaaResults : Page
    {
        //public List<Result> ResultsList;
        public static ObservableCollection<Result> ResultsList;

        public GaaResults()
        {
            this.InitializeComponent();
            loadResults();  
        }

        public void addResultToListView(Result re)
        {      
            ResultsListView.Items.Add(re);      
            ResultsListView.DataContext = ResultsList;    
        }
       
        public void updateListView()
        {
         
        }

        private async void loadResults()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            // create the file and append
            StorageFile sampleFile;
            try
            {
                //get results
                sampleFile = await storageFolder.GetFileAsync("gaaResults.txt");
            }
            catch (Exception myE)
            {
                string message = myE.Message;
                return;
            }
            string fileText = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);

            parseFile(fileText);
        }

        private void parseFile(String fileText)
        {
            //splits up all results
            string[] res = fileText.Split('\n');       

            for (int i= 0;i<res.Length-1;i++) {
                String str= res[i];    
                //add to result
                Result r = new Result(str);
                String ResStr=r.getFormattedResult();
                addResultToListView(r);
            }
        }

        private  void ResultsListView_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //updateListView();
            //MessageDialog m = new MessageDialog("Update");
           //await m.ShowAsync();
        }
    }

    public class Result
    {
        public string result { get; set; }
        public string TeamOneName;
        public string TeamOneGoal;
        public string TeamOnePoint;
        public string TeamTwoName;
        public string TeamTwoGoal;
        public string TeamTwoPoint;
 
        public Result(String ResultString)
        {
            //splits results
            String[] res = ResultString.Split(':');
            this.TeamOneName = res[0];
            this.TeamOneGoal = res[1];
            this.TeamOnePoint = res[2];
            this.TeamTwoName = res[3];
            this.TeamTwoGoal = res[4];
            this.TeamTwoPoint = res[5];
            
            this.result = getFormattedResult();
        }

        public String getFormattedResult()
        {
            String result = TeamOneName + " : " + TeamOneGoal + "-" + TeamOnePoint + " - " + TeamTwoName + " : " + TeamTwoGoal + "-" + TeamTwoPoint;
            return result;
        }

        //tapped event
        public async void Tapped(object sender, TappedRoutedEventArgs e)
        {
            String str = TeamOneName + " : " + TeamOneGoal + "-" + TeamOnePoint + "\n" + TeamTwoName + " : " + TeamTwoGoal + "-" + TeamTwoPoint;

            MessageDialog m = new MessageDialog(str);
            await m.ShowAsync();

        }
    }


}
