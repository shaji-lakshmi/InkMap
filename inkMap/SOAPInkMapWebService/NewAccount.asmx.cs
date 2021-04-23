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
    /// Summary description for NewAccount
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NewAccount : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean AddAccount(Account newAccount)
        {
            if (newAccount != null)
            {
                DBConnect objDB = new DBConnect();
                SqlCommand addAccountcmd = new SqlCommand();

                addAccountcmd.CommandType = CommandType.StoredProcedure;
                addAccountcmd.CommandText = "TP_NewAccount";

                addAccountcmd.Parameters.AddWithValue("@password", newAccount.password);
                addAccountcmd.Parameters.AddWithValue("@accountType", newAccount.accountType);
                addAccountcmd.Parameters.AddWithValue("@firstName", newAccount.firstName);
                addAccountcmd.Parameters.AddWithValue("@lastName", newAccount.lastName);
                addAccountcmd.Parameters.AddWithValue("@email", newAccount.email);
                addAccountcmd.Parameters.AddWithValue("@phoneNumber", newAccount.phoneNumber);

                int result = objDB.DoUpdateUsingCmdObj(addAccountcmd);
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }

    }
}
