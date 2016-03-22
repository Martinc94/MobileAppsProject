using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Match_Tracker
{
    public class Result
    {
        public string result { get; set; }
        public string TeamOneName;
        public string TeamOneGoal;
        public string TeamOnePoint;
        public string TeamTwoName;
        public string TeamTwoGoal;
        public string TeamTwoPoint;
        public string originalString;

        public Result(String ResultString)
        {
            //splits results
            originalString = ResultString;
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
           
            MessageDialog md = new MessageDialog(str);
            md.Commands.Add(new Windows.UI.Popups.UICommand("Delete") { Id = 0 });
            md.Commands.Add(new Windows.UI.Popups.UICommand("Close") { Id = 1 });

            var responce = await md.ShowAsync();

            int switch_on = Convert.ToUInt16(responce.Id);

            switch (switch_on)
            {
                case 0:
                    //load
                    Delete();
                    break;


                default:
                    break;
            }

        }//endTapped


        private void Delete()
        {
            LoadAndDelete();
        }

        private async void  LoadAndDelete()
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
            List<string> reslist = new List<string>(res);

            for (int i = 0; i < reslist.Count - 1; i++)
            {     
                if (reslist[i] == originalString)
                {
                    //found Result
                    //delete from res
                    reslist.RemoveAt(i);
                }
            }

            for (int i = 0; i < reslist.Count - 1; i++)
            {
               
                if (reslist[i] == originalString )
                {
                    //found Result
                    //delete from res
                    reslist.RemoveAt(i);
                              
                }               
            }

            //append to file
            Append(reslist);

        }

        private async void Append(List<string> reslist)
        {             
            var folder = ApplicationData.Current.LocalFolder;
            var textFile = await folder.CreateFileAsync("gaaResults.txt", CreationCollisionOption.OpenIfExists);
            //delete file
            await textFile.DeleteAsync();

            textFile = await folder.CreateFileAsync("gaaResults.txt", CreationCollisionOption.OpenIfExists);

            //loop over list
            for (int i = 0; i < reslist.Count-1; i++){
                //Append to file
                await FileIO.AppendTextAsync(textFile, reslist[i] + "\n");
            }                
        }
    }//end result
}
