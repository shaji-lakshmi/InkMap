using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data;



namespace inkMap
{
    public partial class profileImageGrab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            DataSet ds;
            string strSQL;

            // Get the image from the Image table using GET parameter supplied through the URL

            strSQL = "SELECT ImageData FROM TP_profileImages Where Account_ID = 2";

            ds = objDB.GetDataSet(strSQL);
            byte[] imageData;

            imageData = (byte[])objDB.GetField("ImageData", 0);
            // Write the binary image data in the Response for the browser to display

            Response.Clear();
            Response.OutputStream.Write(imageData, 0, imageData.Length);

            Response.End();
        }
    }
}