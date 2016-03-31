using System;
using System.Collections.ObjectModel;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Match_Tracker
{
    public sealed partial class GaaResults : Page
    {
        public  ObservableCollection<Result> ResultsList;

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
       
        private async void loadResults()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
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

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            ResultsListView.Items.Clear();
            loadResults();
        }
    }

}
