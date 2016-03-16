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
    public sealed partial class GaaResults : Page
    {
        public List<listContent> ContentList { get; set; }
        //possibly make result class

        public GaaResults()
        {
            this.InitializeComponent();
            //test
            listContent listItem = new listContent();
            listItem.Result = "NameOne"+" VS "+"NameTwo";

            ResultsListView.Items.Add(listItem);
           
           /* for (int i = 0;i<50;i++) {
                ResultsListView.Items.Add(listItem);
            }*/
            
            ResultsListView.DataContext = ContentList;
        }

        private async void loadResults()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            // create the file and append
            StorageFile sampleFile;
            try
            {
                //open gaa folder
                //
                sampleFile = await storageFolder.GetFileAsync("results.txt");
            }
            catch (Exception myE)
            {
                string message = myE.Message;
                return;
            }
            string fileText = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            //read line 
            //parse line 
            //add to list
            //output list of results
        }

        public class listContent
        {
            public string Result { get; set; }
            
        }

        public class result
        {
            public string Result { get; set; }
            public string TeamOneName { get; set; }
            public string TeamTwoName { get; set; }

            //add tapped event
        }
    }
}
