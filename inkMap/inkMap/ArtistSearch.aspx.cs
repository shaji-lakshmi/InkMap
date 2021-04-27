using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using InkMapLibrary;
using System.Collections;
using Utilities;
using System.Data;
using System.Data.SqlClient;





namespace inkMap
{
    public partial class ArtistSearch : System.Web.UI.Page
    {

        DBConnect objDB = new DBConnect();
        dbProcedures procedure = new dbProcedures();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLocationSearch_Click(object sender, EventArgs e)
        {
            NewAccountService.NewAccount proxy = new NewAccountService.NewAccount();

            ArrayList artists = new ArrayList(proxy.GetArtistByZip(txtLocationArtist.Text.ToString()));

            //foreach (Artist artist in artists)
            //{
            //    int accountid = int.Parse(Request.QueryString["ID"]);
            //    int artistID = artist.artist_ID;
            //    string redirectLink = "GetArtistProfile.aspx?ID="+accountid+ "&artistID="+artistID;
            //    artists.Add(redirectLink);
                
            //}

            
            //gvArtist.DataSource = artists;
            //gvArtist.DataBind();
            rptsearchResults.DataSource = artists;
            rptsearchResults.DataBind();

            if (artists.Count == 0)
            {
                 lblNoresults.Text = "No results found.";
            }

        }

        protected void lbtnViewProfile_Click(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["ID"]);
            Response.Redirect("GetArtistProfile.aspx?ID="+accountid+"&artistID=44");
        }
    }
}