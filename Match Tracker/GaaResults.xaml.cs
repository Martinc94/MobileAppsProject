using System;
using System.Collections.Generic;
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
        public List<listContent> ContentList { get; set; }

        public List<Result> ResultsList;

        public GaaResults()
        {
            this.InitializeComponent();
            loadResults();
        }

        public void addToListView(String str){
            
            listContent listItem = new listContent();
            listItem.Result = str;
            //listItem.Tap += TextBlock_Tapped;   
            

            ResultsListView.Items.Add(listItem);
            ResultsListView.DataContext = ContentList;
        }

        public void addResultToListView(Result re)
        {

            
            ResultsListView.Items.Add(re);
            //ResultsListView.DataContext = ContentList;
            ResultsListView.DataContext = ResultsList;
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
                //addToListView(res[i]);
                //add to result
                Result r = new Result(str);
                String ResStr=r.getFormattedResult();

                //addToListView(ResStr);

                addResultToListView(r);
            }
        }

        private void OnItemTapped(object sender, TappedEventHandler e)
        {
            /* if (e.Item != null && this.TappedEventHandler != null && this.TappedEventHandler.CanExecute(e))
             {
                 this.ItemClickCommand.Execute(e.Item);
                 this.SelectedItem = null;
             }*/

           // MessageDialog m = new MessageDialog("Tapped");
        }

        public class listContent
        {
            public string Result { get; set; }  
        }

       

       

        private static void OnItemClick(object sender, ItemClickEventArgs e)
        {
            MessageDialog m = new MessageDialog("Tapped");
            
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

        public Result()
        { 

        }

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

        //add tapped event

    }


}
