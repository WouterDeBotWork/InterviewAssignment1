using AssignmentREST.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssignmentREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GUIDController : ControllerBase
    {
        // GET: api/GUID
        [HttpGet]
        public object  StartCalculation()
        {
            // Method used to generate a GUID from two different timestamps combined with a pseudo random number generator.
            // Per the requirements the calculations will take their time (between 20 en 60 seconds). This is done via the Thread.Sleep method
            // A second timestamp variable is created after the random waiting period in order to reduce the chances of 

            long timeStamp1 = DateTimeOffset.Now.ToUnixTimeSeconds();

            Random rnd = new Random();
            int randMiliSeconds = rnd.Next(20, 55)*1000;
            Console.WriteLine($"The waiting time will be: {randMiliSeconds}");

            //Wait
            System.Threading.Thread.Sleep(randMiliSeconds);

            long timeStamp2 = DateTimeOffset.Now.ToUnixTimeSeconds();

            
            var statusObject = new StatusObject
            {
                GUID = timeStamp2 + timeStamp1 + randMiliSeconds
            };

            return statusObject;
        }

        public object GetStatus()
        {
            // Method used to generate a GUID from two different timestamps combined with a pseudo random number generator.
            // Per the requirements the calculations will take their time (between 20 en 60 seconds). This is done via the Thread.Sleep method
            // A second timestamp variable is created after the random waiting period in order to reduce the chances of 

            long timeStamp1 = DateTimeOffset.Now.ToUnixTimeSeconds();

            Random rnd = new Random();
            int randMiliSeconds = rnd.Next(20, 55) * 1000;
            Console.WriteLine($"The waiting time will be: {randMiliSeconds}");

            //Wait
            System.Threading.Thread.Sleep(randMiliSeconds);

            long timeStamp2 = DateTimeOffset.Now.ToUnixTimeSeconds();


            var statusObject = new StatusObject
            {
                GUID = timeStamp2 + timeStamp1 + randMiliSeconds
            };

            return statusObject;
        }

        /*
        // GET: api/GUID
        [HttpGet]
        public IEnumerable<StatusObject> Get()
        {
            var GUIDList = new List<StatusObject>();
            for (int i = 0; i < 10; i++)
            {
                var statusObject = new StatusObject
                {
                    GUID = $"{i}"

                };

                GUIDList.Add(statusObject);
            }
            return GUIDList;
        }

        
        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
