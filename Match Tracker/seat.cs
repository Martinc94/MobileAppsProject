using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml.Input;

namespace Match_Tracker
{
    public class Seat
    {
        public string seatInfo { get; set; }
        public string StadiumName;
        public string coorLAT;
        public string coorLONG;

        public string originalString;

        public Seat(String seatString)
        {
            //splits results
            originalString = seatString;
            String[] str = seatString.Split(':');
            this.StadiumName = str[0];
            this.coorLAT = str[1];
            this.coorLONG = str[2];


            this.seatInfo = getFormatted();
        }

        public String getFormatted()
        {
            String f = StadiumName + " : " + coorLAT + " - " + coorLONG;
            return f;
        }

        //tapped event
        public async void Tapped(object sender, TappedRoutedEventArgs e)
        {
            String str = StadiumName + " : " + coorLAT + "-" + coorLONG;

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

        private async void Delete()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            // create the file and append
            StorageFile sampleFile;
            try
            {
                //get results
                sampleFile = await storageFolder.GetFileAsync("seatCoord.txt");
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
            string[] seat = fileText.Split('\n');
            List<string> list = new List<string>(seat);

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == originalString)
                {
                    //found Result
                    //delete from res
                    list.RemoveAt(i);
                }
            }

            for (int i = 0; i < list.Count - 1; i++)
            {

                if (list[i] == originalString)
                {
                    //found seat and remove   
                    list.RemoveAt(i);
                }
            }

            //append to file
            Append(list);
        }

        private async void Append(List<string> list)
        {
            var folder = ApplicationData.Current.LocalFolder;
            var textFile = await folder.CreateFileAsync("seatCoord.txt", CreationCollisionOption.OpenIfExists);
            //delete file
            await textFile.DeleteAsync();

            textFile = await folder.CreateFileAsync("seatCoord.txt", CreationCollisionOption.OpenIfExists);

            //loop over list
            for (int i = 0; i < list.Count - 1; i++)
            {
                //Append to file
                await FileIO.AppendTextAsync(textFile, list[i] + "\n");
            }
        }
    }

}
