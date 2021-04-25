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
    public partial class CustProfileCreation : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        dbProcedures procedure = new dbProcedures();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                int accountid = int.Parse(Request.QueryString["ID"]);
                DataSet userData = procedure.getcustomerinfo(accountid);

              //Tables[0].Rows[0]["Verification"].ToString();

                lblPrintFname.Text = userData.Tables[0].Rows[0]["Customer_FirstName"].ToString();
                lblPrintLname.Text = userData.Tables[0].Rows[0]["Customer_LastName"].ToString();
                lblPrintEmail.Text = userData.Tables[0].Rows[0]["Email"].ToString();
                lblPrintPhone.Text = userData.Tables[0].Rows[0]["PhoneNumber"].ToString();
            }
            else
            {

            }

        }
    }
}