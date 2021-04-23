using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

<<<<<<< Updated upstream
<<<<<<< Updated upstream
namespace InkMapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
=======
=======
>>>>>>> Stashed changes
using Utilities;
using System.Data;
using InkMapAPI.Models;

namespace InkMapAPI.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
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
                customer.cust_email= record["Email"].ToString();
                customer.cust_phoneNumber = record["PhoneNumber"].ToString();

                CustomerList.Add(customer);
            }
            return CustomerList;
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
