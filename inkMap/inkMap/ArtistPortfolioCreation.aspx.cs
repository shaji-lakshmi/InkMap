using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using InkMapLibrary;
using InkMapAPI.Models;

using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
namespace inkMap
{
    public partial class ArtistPortfolioCreation : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        dbProcedures procedure = new dbProcedures();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] == null)
            {
                Response.Write("<script>alert('Invalid page request. Please go to inkmap.com to get started.')</script>");

            }
        }

        protected void lbtnUploadPortfolio_Click(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["ID"]);
            int imageSize;
            string fileExtension;
            string imgType;
            string imgName;

            try
            {
                if (uploadPortfolio.HasFile)
                {
                    imageSize = uploadPortfolio.PostedFile.ContentLength;
                    byte[] imageData = new byte[imageSize];
                    uploadPortfolio.PostedFile.InputStream.Read(imageData, 0, imageSize);

                    imgName = uploadPortfolio.PostedFile.FileName;
                    imgType = uploadPortfolio.PostedFile.ContentType;

                    fileExtension = imgName.Substring(imgName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();

                    if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                    {
                        int updateDB = procedure.updatePortfolioPic(accountid, imgName, imgType, imageData, imageData.Length);
                        Response.Redirect("ArtistLandingPage.aspx?ID="+accountid); 
                    }
                    else
                    {
                        Response.Write("<script>alert('This site does not accept the file type you uploaded. Please submit a .jpg, .jpeg or .png file.')</script>");

                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        protected void lbtnAddMore_Click(object sender, EventArgs e)
        {
            int accountid = int.Parse(Request.QueryString["ID"]);
            int imageSize;
            string fileExtension;
            string imgType;
            string imgName;

            try
            {
                if (uploadPortfolio.HasFile)
                {
                    imageSize = uploadPortfolio.PostedFile.ContentLength;
                    byte[] imageData = new byte[imageSize];
                    uploadPortfolio.PostedFile.InputStream.Read(imageData, 0, imageSize);

                    imgName = uploadPortfolio.PostedFile.FileName;
                    imgType = uploadPortfolio.PostedFile.ContentType;

                    fileExtension = imgName.Substring(imgName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();

                    if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                    {
                        int updateDB = procedure.updatePortfolioPic(accountid, imgName, imgType, imageData, imageData.Length);
                        Response.Write("<script>alert('Your image has been uploaded. Please Pick your next entry.')</script>");

                    }
                    else
                    {
                        Response.Write("<script>alert('This site does not accept the file type you uploaded. Please submit a .jpg, .jpeg or .png file.')</script>");

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}