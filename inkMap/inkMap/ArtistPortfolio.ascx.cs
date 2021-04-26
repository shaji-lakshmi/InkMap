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
    public partial class ArtistPortfolio : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["ID"]);
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
                lblName.Text = info.Tables[0].Rows[0]["Artist_FirstName"].ToString() + info.Tables[0].Rows[0]["Artist_LastName"].ToString();
                lblEmail.Text = info.Tables[0].Rows[0]["Email"].ToString();
                lblPhone.Text = info.Tables[0].Rows[0]["PhoneNumber"].ToString();
                lblLocation.Text = info.Tables[0].Rows[0]["City"].ToString() + ", " + info.Tables[0].Rows[0]["Artist_State"].ToString();
                lblRating.Text = info.Tables[0].Rows[0]["Rating"].ToString()+ " Stars";
                lblCompany.Text = info.Tables[0].Rows[0]["Company"].ToString();
                imgprofile.ImageUrl = "profileImageGrab.aspx?ID=" + accountid;


            }
        }
    } }