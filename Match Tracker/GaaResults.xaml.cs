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


        //test
       // String str="0";

        public GaaResults()
        {
            this.InitializeComponent();
            loadResults();
            //fillListView();
            
            
        }

        private void addToListView(String str){
            
            listContent listItem = new listContent();

            listItem.Result = str;

            ResultsListView.Items.Add(listItem);
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
                sampleFile = await storageFolder.GetFileAsync("gaaResults.txt");
            }
            catch (Exception myE)
            {
                string message = myE.Message;
                return;
            }
            string fileText = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            

            //test
            //string str = fileText;

            parseFile(fileText);

            //addToListView(str);

            

            //Windows.UI.Popups.MessageDialog m = new Windows.UI.Popups.MessageDialog(str);

            //read line 
            //parse line 
            //add to list
            //output list of results
        }

        private void parseFile(String fileText)
        {
            //string[] res = fileText.Split('\n');
            string[] res = fileText.Split('\n');
          //  addToListView(res[0]);
           // addToListView(res[1]);
           // addToListView(res[2]);

            for (int i= 0;i<res.Length;i++) {
                String str= res[i];
                addToListView(res[i]);
            }
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

            //split by :
            /* for (int i = 0; i<res.Length;i++) {
                String str = res[i];
                addToListView(res[i]);
            }*/
    }
    }
}
