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
    public sealed partial class SoccerResults : Page
    {
        public ObservableCollection<ResultsSoccer> ResultsList;

        public SoccerResults()
        {
            this.InitializeComponent();
            loadResults();  
        }

        public void addResultToListView(ResultsSoccer re)
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
                sampleFile = await storageFolder.GetFileAsync("soccerResults.txt");
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
                ResultsSoccer r = new ResultsSoccer(str);
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
