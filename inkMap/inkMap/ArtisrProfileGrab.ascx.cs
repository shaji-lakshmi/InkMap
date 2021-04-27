using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using InkMapLibrary;

namespace inkMap
{
    public partial class ArtisrProfileGrab : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["artistID"]);
            DBConnect objDB = new DBConnect();
            dbProcedures procedure = new dbProcedures();
            DataSet portImages = procedure.getprotimages(accountid);

            portImages.Tables[0].Columns.Add("imgFile");
            for (int i = 0; i < portImages.Tables[0].Rows.Count; i++)
            {
                portImages.Tables[0].Rows[i]["imgFile"] = "PortImagesGrab.aspx?ID=" + accountid + "&imgID=" + portImages.Tables[0].Rows[i]["porfolio_ImageID"];


                rptImages.DataSource = portImages;
                rptImages.DataBind();

                DataSet info = procedure.getArtistInfo(accountid);
                lblgName.Text = info.Tables[0].Rows[0]["Artist_FirstName"].ToString() + info.Tables[0].Rows[0]["Artist_LastName"].ToString();
                lblgEmail.Text = info.Tables[0].Rows[0]["Email"].ToString();
                lblgPhone.Text = info.Tables[0].Rows[0]["PhoneNumber"].ToString();
                lblgLocation.Text = info.Tables[0].Rows[0]["City"].ToString() + ", " + info.Tables[0].Rows[0]["Artist_State"].ToString();
                lblgRating.Text = info.Tables[0].Rows[0]["Rating"].ToString() + " Stars";
                lblgCompany.Text = info.Tables[0].Rows[0]["Company"].ToString();
                gimgprofile.ImageUrl = "profileImageGrab.aspx?ID=" + accountid;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtartistid.Text);
            // Create an HTTP Web Request and get the HTTP Web Response from the server.
            WebRequest request = WebRequest.Create("https://localhost:44328/api/Customer/GetTestimonials/" + id);
            WebResponse response = request.GetResponse();


            // Read the data from the Web Response, which requires working with streams.
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();


            // Deserialize a JSON string into a Team object.
            JavaScriptSerializer js = new JavaScriptSerializer();
            Testimonial[] comment = js.Deserialize<Testimonial[]>(data);

            gvTestimonials.DataSource = comment;
            gvTestimonials.DataBind();
        }
    }
}