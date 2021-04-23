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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public String email;
        public String phoneNumber;
        //public int Account_ID;

        public String Customer_FirstName
=======
=======
>>>>>>> Stashed changes
        public String cust_email;
        public String cust_phoneNumber;
        //public int Account_ID;

        public String Cust_FirstName
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        {
            get { return customer_FirstName; }
            set { customer_FirstName = value; }
        }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public String Customer_LastName
=======
        public String Cust_LastName
>>>>>>> Stashed changes
=======
        public String Cust_LastName
>>>>>>> Stashed changes
        {
            get { return customer_LastName; }
            set { customer_LastName = value; }
        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
=======
=======
>>>>>>> Stashed changes
        public String Cust_Email
        {
            get { return cust_email; }
            set { cust_email = value; }
        }
        public String Cust_PhoneNumber
        {
            get { return cust_phoneNumber; }
            set { cust_phoneNumber = value; }
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }



    }
}
