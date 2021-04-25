using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using InkMapLibrary;
using Utilities;
using System.Data;
using System.Data.SqlClient;


namespace SOAPInkMapWebService
{
    /// <summary>
    /// Summary description for NewAccount
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NewAccount : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean AddAccount(Account newAccount)
        {
            if (newAccount != null)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand addAccountcmd = new SqlCommand();

                addAccountcmd.CommandType = CommandType.StoredProcedure;
                addAccountcmd.CommandText = "TP_NewAccount";

                addAccountcmd.Parameters.AddWithValue("@password", newAccount.password);
                addAccountcmd.Parameters.AddWithValue("@accountType", newAccount.accountType);
                addAccountcmd.Parameters.AddWithValue("@firstName", newAccount.firstName);
                addAccountcmd.Parameters.AddWithValue("@lastName", newAccount.lastName);
                addAccountcmd.Parameters.AddWithValue("@email", newAccount.email);
                addAccountcmd.Parameters.AddWithValue("@phoneNumber", newAccount.phoneNumber);

                int result = objDB.DoUpdateUsingCmdObj(addAccountcmd);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }

        [WebMethod]
        public Boolean AddArtist (Artist art)
        {
            if (art != null)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand addAccountcmd = new SqlCommand();

                addAccountcmd.CommandType = CommandType.StoredProcedure;
                addAccountcmd.CommandText = "TP_AddArtist";

                addAccountcmd.Parameters.AddWithValue("@artist_FName", art.artist_FName);
                addAccountcmd.Parameters.AddWithValue("@artist_LName", art.artist_LName);
                addAccountcmd.Parameters.AddWithValue("@artist_Email", art.email);
                addAccountcmd.Parameters.AddWithValue("@artist_PhoneNumber", art.phoneNumber);
                addAccountcmd.Parameters.AddWithValue("@artist_Company", art.company);
                addAccountcmd.Parameters.AddWithValue("@artist_Rating", art.rating);
                addAccountcmd.Parameters.AddWithValue("@artist_Certification", art.certification);
                addAccountcmd.Parameters.AddWithValue("@artist_City", art.city);
                addAccountcmd.Parameters.AddWithValue("@artist_State", art.state);
                addAccountcmd.Parameters.AddWithValue("@artist_Zipcode", art.zipcode);
                addAccountcmd.Parameters.AddWithValue("@artist_StreetAddress", art.streetAddress);
                addAccountcmd.Parameters.AddWithValue("@artist_Address2", art.address2);

                int result = objDB.DoUpdateUsingCmdObj(addAccountcmd);

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        [WebMethod]
        public Boolean AddCustomer (Account customer)
        {
            if (customer != null)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand addAccountcmd = new SqlCommand();

                addAccountcmd.CommandType = CommandType.StoredProcedure;
                addAccountcmd.CommandText = "TP_AddCustomer";

                addAccountcmd.Parameters.AddWithValue("@cust_FName", customer.firstName);
                addAccountcmd.Parameters.AddWithValue("@cust_LName", customer.lastName);
                addAccountcmd.Parameters.AddWithValue("@cust_Email", customer.email);
                addAccountcmd.Parameters.AddWithValue("@cust_PhoneNumber", customer.phoneNumber);

                int result = objDB.DoUpdateUsingCmdObj(addAccountcmd);

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
