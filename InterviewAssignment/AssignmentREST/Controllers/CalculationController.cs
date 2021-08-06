using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssignmentInterview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        // Because no database has been connected yet the StatusObject will be stored in the CalculationController class.
        // In a real application this would be saved to a database

        object CurrentStatusObject = new Models.StatusObject();

        // GET: api/age/length
        [HttpGet("{age}/{length}")]
        public object StartCalculation(int age, int length)
        {
            var statusObject = new Models.StatusObject
            {
                GUID = Guid.NewGuid().ToString(),
                status = "completed",
                progress = "100%",
                result = (age + length).ToString()
            };
            //Wait
            int MiliSecondsWait = 20000;
            System.Threading.Thread.Sleep(MiliSecondsWait);

            return statusObject;
        }

        // GET api/<CalculationController>/5
        [HttpGet("{GUID}")]
        public object GetStatus(string GUID)
        {
            return "value";
        }

 
    }
}
