using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Security.Cryptography;     // needed for the encryption classes
using System.IO;                        // needed for the MemoryStream
using System.Text;                      // needed for the UTF8 encoding
using System.Net;                       // needed for the cookie
<<<<<<< Updated upstream
=======
using InkMapLibrary;
using System.Collections;
>>>>>>> Stashed changes

namespace inkMap
{
    public partial class Default : System.Web.UI.Page
    {
        private Byte[] key = { 250, 101, 18, 76, 45, 135, 207, 118, 4, 171, 3, 168, 202, 241, 37, 199 };
        private Byte[] vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 252, 112, 79, 32, 114, 156 };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["Login"] != null)
            {
                HttpCookie cookie = Request.Cookies["Login"];
                String encryptedPassword = cookie.Values["Password"];

                Byte[] encryptedPasswordBytes = Convert.FromBase64String(encryptedPassword);
                Byte[] textBytes;
                String plainTextPassword;

                UTF8Encoding encoder = new UTF8Encoding();

                // Perform Decryption
                //-------------------
                // Create an instances of the decryption algorithm (Rinjdael AES) for the encryption to perform,
                // a memory stream used to store the decrypted data temporarily, and
                // a crypto stream that performs the decryption algorithm.
                RijndaelManaged rmEncryption = new RijndaelManaged();
                MemoryStream myMemoryStream = new MemoryStream();
                CryptoStream myDecryptionStream = new CryptoStream(myMemoryStream, rmEncryption.CreateDecryptor(key, vector), CryptoStreamMode.Write);

                // Use the crypto stream to perform the decryption on the encrypted data in the byte array.
                myDecryptionStream.Write(encryptedPasswordBytes, 0, encryptedPasswordBytes.Length);
                myDecryptionStream.FlushFinalBlock();

                // Retrieve the decrypted data from the memory stream, and write it to a separate byte array.
                myMemoryStream.Position = 0;
                textBytes = new Byte[myMemoryStream.Length];
                myMemoryStream.Read(textBytes, 0, textBytes.Length);

                // Close all the streams.
                myDecryptionStream.Close();
                myMemoryStream.Close();

                // Convert the bytes to a string and display it.
                plainTextPassword = encoder.GetString(textBytes);
                txtEmail.Text = cookie.Values["UserName"].ToString();
                txtPass.Text = plainTextPassword;

<<<<<<< Updated upstream
            }

=======
                

                
            }
            
>>>>>>> Stashed changes

        }
        protected void saveLogIn_Click(object sender, EventArgs e)
        {
            String username = txtEmail.Text;
            String plainTextPwd = txtPass.Text;
            String encryptPwd;

            UTF8Encoding encoder = new UTF8Encoding();
            Byte[] txtBytes;

            //Converts string to byte array
            txtBytes = encoder.GetBytes(plainTextPwd);

            Rijndael rmEncrpytion = new RijndaelManaged();
            MemoryStream memStream = new MemoryStream();
            CryptoStream encryptStream = new CryptoStream(memStream, rmEncrpytion.CreateEncryptor(key, vector), CryptoStreamMode.Write);

            //Use crypto stream to encrypt on plain text byte array
            encryptStream.Write(txtBytes, 0, txtBytes.Length);
            encryptStream.FlushFinalBlock();

            //Retrieve encrypt data from memory stream and write to separate byte array
            memStream.Position = 0;
            Byte[] encryptBytes = new Byte[memStream.Length];
            memStream.Read(encryptBytes, 0, encryptBytes.Length);

            //Close all streams
            encryptStream.Close();
            memStream.Close();

            encryptPwd = Convert.ToBase64String(encryptBytes);

            HttpCookie cookye = new HttpCookie("Login");
            cookye.Values["UserName"] = username;
            cookye.Values["Password"] = encryptPwd;
            cookye.Expires = new DateTime(2099, 1, 1);
            Response.Cookies.Add(cookye);

            lblStoreName.Text = "Username has been stored!";
<<<<<<< Updated upstream

        }
        protected void deleteLogIn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Login"] != null)
            {
                Response.Cookies["Login"].Expires = DateTime.Now.AddDays(-1);
            }

            lblStoreName.Text = "Username has been deleted!";
            txtEmail.Text = " ";
            txtPass.Text = " ";
        }
=======

        }
        protected void deleteLogIn_Click(object sender, EventArgs e)
        {
           if(Request.Cookies["Login"] != null)
            {
                Response.Cookies["Login"].Expires = DateTime.Now.AddDays(-1);
            }

            lblStoreName.Text = "Username has been deleted!";
            txtEmail.Text = " ";
            txtPass.Text = " ";
        }

        protected void lbtnCreateAccountCustomer_Click(object sender, EventArgs e)
        {
            NewAccountService.Account AccountInfo = new NewAccountService.Account();

            AccountInfo.password = txtConfirmPass.Text;
            AccountInfo.accountType = "customer";
            AccountInfo.firstName = txtCustomerFName.Text;
            AccountInfo.lastName = txtCustomerLName.Text;
            AccountInfo.email = txtCustomerEmail.Text;
            AccountInfo.phoneNumber = txtCustomerPhone.Text;

            NewAccountService.NewAccount proxy = new NewAccountService.NewAccount();

           if(proxy.AddAccount(AccountInfo))
            {
                lblStoreName.Text = "Account was created successfully!";

            }
           else
            {
                lblStoreName.Text = "Account was not created D:";

            }
           

            //if(stored > -1)
            //{
            //    Response.Redirect("Default.aspx");
            //    lblStoreName.Text = "Your account has been created! Please sign in to confirm log in.";
            //}
            //else
            //{
            //    lblStoreName.Text = "Account not added";
            //}



        }
>>>>>>> Stashed changes


    }
}