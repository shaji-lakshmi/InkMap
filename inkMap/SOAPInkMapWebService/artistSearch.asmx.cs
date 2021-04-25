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
    /// Summary description for artistSearch
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class artistSearch : System.Web.Services.WebService
    {
        DBConnect dBConnect = new DBConnect();

        [WebMethod]
        public Artist GetArtistByZip(String zip)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand getArtistLocation = new SqlCommand();

            getArtistLocation.CommandType = CommandType.StoredProcedure;
            getArtistLocation.CommandText = "TP_searchLocation";
            getArtistLocation.Parameters.AddWithValue("@location", zip);

            DataSet result = objDB.GetDataSetUsingCmdObj(getArtistLocation);

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

            return artist;
        }
    }
}
