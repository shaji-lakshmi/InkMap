using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InkMapAPI.Models
{
    public class Customers
    {
        //public int Customer_ID;
        public String customer_FirstName;
        public String customer_LastName;
        public String email;
        public String phoneNumber;
        //public int Account_ID;

        public String Customer_FirstName
        {
            get { return customer_FirstName; }
            set { customer_FirstName = value; }
        }

        public String Customer_LastName
        {
            get { return customer_LastName; }
            set { customer_LastName = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }



    }
}
