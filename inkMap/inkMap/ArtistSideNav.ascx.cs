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
using InkMapLibrary;
namespace inkMap
{
	public partial class ArtistSideNav1 : System.Web.UI.UserControl
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            DBConnect objDB = new DBConnect();
            dbProcedures procedure = new dbProcedures();

            if (Request.QueryString["ID"] != null)
            {
                int accountid = int.Parse(Request.QueryString["ID"]);
                imgprofileImage.ImageUrl = "profileImageGrab.aspx?ID=" + accountid;

                DataSet AccountData = procedure.getAccountInfo(accountid);
                 lblAccountName.Text =AccountData.Tables[0].Rows[0]["FirstName"].ToString() + " " + AccountData.Tables[0].Rows[0]["LastName"].ToString();

            }
        }

        protected void lbtnSearch_Click(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["ID"]);
            Response.Redirect("ArtistSearch.aspx?ID=" + accountid);
        }
    }
}