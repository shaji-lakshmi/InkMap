using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InkMapLibrary
{
    public class Testimonial
    {
        public int testimonial_ID;
        public int artist_ID;
        public int cust_ID;
        public String title;
        public String body;
        public String artist_FName;
        public String artist_LName;


        public int Testimonial_ID
        {
            get { return testimonial_ID; }
            set { testimonial_ID = value; }
        }
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
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public String Body
        {
            get { return body; }
            set { body = value; }
        }
        public String Artist_FName
        {
            get { return artist_FName; }
            set { artist_FName = value; }
        }
        public String Artist_LName
        {
            get { return artist_LName; }
            set { artist_LName = value; }
        }
    }
}