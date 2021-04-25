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
    public partial class verification : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            dbProcedures procedure = new dbProcedures();

            if (Request.QueryString["ID"] != null)
            {

                int accountid = int.Parse(Request.QueryString["ID"]);
                DataSet userData = procedure.getVerificationInformation(accountid);

                int updateStatus = procedure.updateAccountVerification(accountid);
                // strSQL = "SELECT FirstName, LastName FROM TP_Account Where Account_ID = " + Request.QueryString["ID"];
                // ds = objDB.GetDataSet(strSQL);

                if (updateStatus == 1)
                {
                    string fName = userData.Tables[0].Rows[0]["FirstName"].ToString();
                    string lName = userData.Tables[0].Rows[0]["LastName"].ToString();
                    string accountName = fName + " " + lName;
                    lblVerificationInfo.Text = accountName;
                }
                else
                {
                    Response.Write("<script>alert('Something went wrong with your verification. Please contact system admins.')</script>");

                }

            }
        }
    }
}