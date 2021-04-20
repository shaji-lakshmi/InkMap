using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace inkMap
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserName"] != null)
                {
                    HttpCookie cookie = Request.Cookies["UserName"];
                    txtEmail.Text = cookie.Values["UserName"].ToString();
                }
                else
                {
                    txtEmail.Text = " ";
                }
            }
           

        }
        protected void saveLogIn_Click(object sender, EventArgs e)
        {
            HttpCookie LogIn = new HttpCookie("UserName");
            LogIn.Values["UserName"] = txtEmail.Text;
            LogIn.Values["LastVisited"] = DateTime.Now.ToString();
            LogIn.Expires = new DateTime(2099, 1, 1);

            Response.Cookies.Add(LogIn);
            lblStoreName.Text = "Username has been stored!";
        }
        protected void deleteLogIn_Click(object sender, EventArgs e)
        {
           if(Request.Cookies["UserName"] != null)
            {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
            }
            lblStoreName.Text = "Username has been deleted!";
            txtEmail.Text = " ";
        }
    }
}