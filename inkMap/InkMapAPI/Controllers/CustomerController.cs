using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Utilities;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using InkMapAPI.Models;

namespace InkMapAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        DBConnect dBConnect = new DBConnect();
        // GET: api/Customer
        [HttpGet]
        public List<Customers> GetAllCustomers()
        {
            List<Customers> CustomerList = new List<Customers>();
            DataSet customers = dBConnect.GetDataSet("SELECT * FROM TP_Customer");

            foreach (DataRow record in customers.Tables[0].Rows)
            {
                Customers customer = new Customers();
                customer.customer_FirstName = record["Customer_FirstName"].ToString();
                customer.customer_LastName = record["Customer_LastName"].ToString();
                customer.cust_email = record["Email"].ToString();
                customer.cust_phoneNumber = record["PhoneNumber"].ToString();

                CustomerList.Add(customer);
            }
            return CustomerList;
        }

        // GET: api/Customer/GetTestimonials/
        [HttpGet("GetTestimonials/{artist_ID}")]
        public List<Testimonial> GetAllTestimonials(int artist_ID)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetAllTestimonials";

            List<Testimonial> TestimonialList = new List<Testimonial>();

            SqlParameter artistID = new SqlParameter("@artist_ID", artist_ID);
            artistID.Direction = ParameterDirection.Input;
            objCommand.Parameters.Add(artistID);

            DataSet testimonials = objDB.GetDataSetUsingCmdObj(objCommand);

            foreach (DataRow record in testimonials.Tables[0].Rows)
            {
                Testimonial comment = new Testimonial();
                comment.artist_ID = Int32.Parse(record["Artist_ID"].ToString());
                comment.title = record["Title"].ToString();
                comment.body = record["Body"].ToString();

                TestimonialList.Add(comment);
            }
            return TestimonialList;
        }

        // GET: api/Customer/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Customer/SaveTestimonial/
        [HttpPost("SaveTestimonial/")]
        public Boolean Post([FromBody] Testimonial comment)
        {

            DBConnect objDB = new DBConnect();
            SqlCommand addTestcmd = new SqlCommand();

            addTestcmd.CommandType = CommandType.StoredProcedure;
            addTestcmd.CommandText = "TP_AddTestimonial";

            addTestcmd.Parameters.AddWithValue("@artist_ID", comment.artist_ID);
            addTestcmd.Parameters.AddWithValue("@cust_ID", comment.cust_ID);
            addTestcmd.Parameters.AddWithValue("@title", comment.title);
            addTestcmd.Parameters.AddWithValue("@body", comment.body);

            int result = objDB.DoUpdateUsingCmdObj(addTestcmd);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // PUT: api/Customer/EditTestimonial/{test_ID}
        [HttpPut("EditTestimonial/{test_ID}")]
        public Boolean Put(int test_ID, [FromBody] Testimonial comment)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand addTestcmd = new SqlCommand();

            addTestcmd.CommandType = CommandType.StoredProcedure;
            addTestcmd.CommandText = "TP_EditTestimonial";

            addTestcmd.Parameters.AddWithValue("@testimonial_ID", comment.testimonial_ID);
            addTestcmd.Parameters.AddWithValue("@title", comment.title);
            addTestcmd.Parameters.AddWithValue("@body", comment.body);

            int result = objDB.DoUpdateUsingCmdObj(addTestcmd);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
