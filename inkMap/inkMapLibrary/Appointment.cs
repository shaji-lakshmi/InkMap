using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InkMapLibrary
{
    public class Appointment
    {
        public int artist_ID;
        public int cust_ID;
        public String date;
        public String time;

        public int Artist_ID
        {
            get { return artist_ID; }
            set { artist_ID = value; }
        }
        public int Cust_ID
        {
            get { return cust_ID; }
            set { cust_ID = value; }
        }
        public String Date
        {
            get { return date; }
            set { date = value; }
        }
        public String Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}