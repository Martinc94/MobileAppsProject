using System;
using System.Collections.ObjectModel;
using Windows.Devices.Geolocation;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Match_Tracker
{
    public sealed partial class seatLocation : Page
    {
        Geolocator myGeo;
        uint _desiredAccuracy = 1;
        string sName;
        String lon;
        String lat;
        bool ready=false;

        public ObservableCollection<Seat> SeatList;

        public seatLocation()
        {
            this.InitializeComponent();
            //setup geo
            setupGeoLocation();
            loadResults();
        }

        private async void setupGeoLocation()
        {
            // ask for permission 
            var accessStatus = await Geolocator.RequestAccessAsync();
            switch (accessStatus)
            {
                case GeolocationAccessStatus.Allowed:
                    {
                        myGeo = new Geolocator { DesiredAccuracyInMeters = _desiredAccuracy };
                        myGeo.ReportInterval = (uint)5000;
                        // status changed, position changed events
                        myGeo.StatusChanged += MyGeo_StatusChanged;
                        myGeo.PositionChanged += MyGeo_PositionChanged;
                        // get our current position.
                        Geoposition pos = await myGeo.GetGeopositionAsync();        
                        break;
                    }
                case GeolocationAccessStatus.Denied:
                    {
                        MessageDialog myMsg = new MessageDialog("Please turn on location data");
                        await myMsg.ShowAsync();
                        break;
                    }
                default:
                    {
                        MessageDialog myMsg = new MessageDialog("Unspecified problem accessing location data");
                        await myMsg.ShowAsync();
                        break;
                    }
            }
        }

        private async void MyGeo_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                txtCoordinates.Text =
                                  args.Position.Coordinate.Latitude.ToString() + " : " + args.Position.Coordinate.Longitude.ToString();

                lat = args.Position.Coordinate.Latitude.ToString();
                lon = args.Position.Coordinate.Longitude.ToString();
                
            });
        }

        private async void MyGeo_StatusChanged(Geolocator sender, StatusChangedEventArgs args)
        {
            // use the dispatcher with lambda fuction to update the UI thread.
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                // code to run in method to update UI
                switch (args.Status)
                {
                    case PositionStatus.Ready:
                        // what here?
                        statusUpdates.Text = "Locations services normal";
                        ready = true;
                        break;
                    case PositionStatus.Disabled:
                        statusUpdates.Text = "Turn on location services";
                        ready = false;
                        break;
                    case PositionStatus.NoData:
                        statusUpdates.Text = "No data received from Location services";
                        ready = false;
                        break;
                    case PositionStatus.Initializing:
                        statusUpdates.Text = "Initialising Location services";
                        ready = false;
                        break;
                    default:
                        statusUpdates.Text = "Unknown problem with your location services";
                        ready = false;
                        break;
                }

            });

        }

        private async void loadResults()
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
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
            string[] res = fileText.Split('\n');

            for (int i = 0; i < res.Length - 1; i++)
            {
                String str = res[i];
                //add to result
                Seat s = new Seat(str);
                String ResStr = s.getFormatted();
                addSeatToListView(s);
            }
        }

        private void addSeatToListView(Seat s)
        {
            SeatListView.Items.Add(s);
            SeatListView.DataContext = SeatList;
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            sName = txtStad.Text;

            if (sName=="") {
                sName = "unnamed";
            }

            if (ready) {
                //Append to file
                var folder = ApplicationData.Current.LocalFolder;
                var textFile = await folder.CreateFileAsync("seatCoord.txt", CreationCollisionOption.OpenIfExists);
                await FileIO.AppendTextAsync(textFile, sName + ":" + lat + ":" + lon + System.Environment.NewLine);

            }

            //refresh list view
            Refresh();
        }

        private void Refresh()
        {
            SeatListView.Items.Clear();
            loadResults();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            SeatListView.Items.Clear();
            loadResults();
        }

    }
}
