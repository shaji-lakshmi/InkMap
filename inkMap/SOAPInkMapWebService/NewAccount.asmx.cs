using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using InkMapLibrary;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

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
        public Boolean AddArtist(Artist art)
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
        public Boolean AddCustomer(Account customer)
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

        [WebMethod]
        public ArrayList GetArtistByZip(String zip)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_searchLocation";

            SqlParameter location = new SqlParameter("@location", zip);
            location.Direction = ParameterDirection.Input;
            objCommand.Parameters.Add(location);

            DataSet result = objDB.GetDataSetUsingCmdObj(objCommand);
            int size = result.Tables[0].Rows.Count;
            ArrayList art = new ArrayList();

            for (int i = 0; i < size; i++)
            {
                Artist artist = new Artist();
                artist.artist_FName = result.Tables[0].Rows[0]["Artist_FirstName"].ToString();
                artist.artist_LName = result.Tables[0].Rows[0]["Artist_LastName"].ToString();
                artist.email = result.Tables[0].Rows[0]["Email"].ToString();
                artist.phoneNumber = result.Tables[0].Rows[0]["PhoneNumber"].ToString();
                artist.company = result.Tables[0].Rows[0]["Company"].ToString();
                artist.rating = Convert.ToDecimal(result.Tables[0].Rows[0]["Rating"].ToString());
                artist.streetAddress = result.Tables[0].Rows[0]["StreetAddress"].ToString();
                artist.address2 = result.Tables[0].Rows[0]["Address2"].ToString();
                artist.city = result.Tables[0].Rows[0]["City"].ToString();
                artist.state = result.Tables[0].Rows[0]["Artist_State"].ToString();
                artist.zipcode = result.Tables[0].Rows[0]["Zipcode"].ToString();
                artist.artist_ID = Int32.Parse(result.Tables[0].Rows[0]["Artist_ID"].ToString());
                artist.certification = result.Tables[0].Rows[0]["Certification"].ToString();

                art.Add(artist);
            }

            return art;
        }

        [WebMethod]
        [XmlInclude(typeof(Testimonial))]
        public Boolean AddTestimonial(Testimonial comment)
        {
            if (comment != null)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand addTestcmd = new SqlCommand();

                addTestcmd.CommandType = CommandType.StoredProcedure;
                addTestcmd.CommandText = "TP_AddTestimonial";

                addTestcmd.Parameters.AddWithValue("@artist_ID", comment.artist_ID);
                addTestcmd.Parameters.AddWithValue("@cust_ID", comment.cust_ID);
                addTestcmd.Parameters.AddWithValue("@title", comment.title);
                addTestcmd.Parameters.AddWithValue("@body", comment.body);

                int result = objDB.DoUpdateUsingCmdObj(addTestcmd);

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
        [XmlInclude(typeof(Appointment))]
        public Boolean ScheduleAppointment(Appointment appt)
        {
            if (appt != null)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand addTestcmd = new SqlCommand();

                addTestcmd.CommandType = CommandType.StoredProcedure;
                addTestcmd.CommandText = "TP_ScheduleAppointment";

                addTestcmd.Parameters.AddWithValue("@artist_ID", appt.artist_ID);
                addTestcmd.Parameters.AddWithValue("@cust_ID", appt.cust_ID);
                addTestcmd.Parameters.AddWithValue("@date", appt.date);
                addTestcmd.Parameters.AddWithValue("@time", appt.time);

                int result = objDB.DoUpdateUsingCmdObj(addTestcmd);

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
