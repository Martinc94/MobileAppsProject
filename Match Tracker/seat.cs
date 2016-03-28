using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Input;

namespace Match_Tracker
{
    class seat
    {
        public string seatInfo { get; set; }
        public string StadiumName;
        public string coorLAT;
        public string coorLONG;

        public string originalString;

        public seat(String seatString)
        {
            //splits results
            originalString = seatString;
            String[] str = seatString.Split(':');
            this.StadiumName = str[0];
            this.coorLAT = str[1];
            this.coorLAT = str[1];


            this.seatInfo = getFormatted();
        }

        public String getFormatted()
        {
            String f = StadiumName + " : " + coorLAT + " - " + coorLONG;
            return f;
        }

        //tapped event
        public void Tapped(object sender, TappedRoutedEventArgs e)
        {


        }//endTapped





    }

}
