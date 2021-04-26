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
    [ApiController]
    public class PortfolioPicsController : ControllerBase
    {
        DBConnect dbConnect = new DBConnect();
        // GET: api/PortfolioPics
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PortfolioPics/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PortfolioPics
        [HttpPost]
        public Boolean Post([FromBody] Portfolio image) 
        {
            SqlCommand procedure = new SqlCommand();
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.CommandText = "TP_updateAppointments";

            SqlParameter artistvalue = new SqlParameter("@artist", image.artistid);
            artistvalue.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(artistvalue);

            SqlParameter customervalue = new SqlParameter("@customer", image.customerid);
            customervalue.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(customervalue);

            SqlParameter datevalue = new SqlParameter("@date", image.date);
            datevalue.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(datevalue);

            SqlParameter timevalue = new SqlParameter("@time", image.time);
            timevalue.Direction = ParameterDirection.Input;
            procedure.Parameters.Add(timevalue);

            int uploadResult = dbConnect.DoUpdateUsingCmdObj(procedure);


            if (uploadResult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // PUT: api/PortfolioPics/5
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
