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

namespace inkMap
{
    public partial class ArtistPortfolioCreation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
                if (uploadportfoliopics.HasFile)
                {
                    imageSize = uploadportfoliopics.PostedFile.ContentLength;
                    byte[] imageData = new byte[imageSize];

                    uploadportfoliopics.PostedFile.InputStream.Read(imageData, 0, imageSize);
                    imgName = uploadportfoliopics.PostedFile.FileName;
                    imgType = uploadportfoliopics.PostedFile.ContentType;

                    fileExtension = imgName.Substring(imgName.LastIndexOf("."));
                    fileExtension = fileExtension.ToLower();

                    if (fileExtension == ".jpg" || fileExtension == ".jpeg" || fileExtension == ".png")
                    {
                        //Response.Write("<script>alert('Correct File has been used.')</script>");

                        Portfolio image = new Portfolio();
                        image.accountid = accountid;
                        image.title = imgName;
                        image.type = imgType;
                        image.data = imageData;
                        image.length = imageData.Length; 

                        JavaScriptSerializer js = new JavaScriptSerializer();
                        String jsonTeam = js.Serialize(image);
                        try{

                            // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.

                            WebRequest request = WebRequest.Create("https://localhost:44328/api/PortfolioPics");
                            request.Method = "POST";
                            request.ContentLength = jsonTeam.Length;
                            request.ContentType = "application/json";
                            // Write the JSON data to the Web Request

                            StreamWriter writer = new StreamWriter(request.GetRequestStream());
                            writer.Write(jsonTeam);
                            writer.Flush();
                            writer.Close();

                            // Read the data from the Web Response, which requires working with streams.
                            WebResponse response = request.GetResponse();
                            Stream theDataStream = response.GetResponseStream();
                            StreamReader reader = new StreamReader(theDataStream);
                            String data = reader.ReadToEnd();
                            reader.Close();
                            response.Close();
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('This site does not accept the file type you uploaded. Please submit a .jpg, .jpeg or .png file.')</script>");

                    }


                    }
            }
            catch { 
            }
           
            {

            }
         
        }
    }
}