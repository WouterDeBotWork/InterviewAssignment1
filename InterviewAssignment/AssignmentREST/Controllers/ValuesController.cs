﻿using AssignmentREST.Models;
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
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<TestModel> Get()
        {
            var testList = new List<TestModel>();
            for (int i = 0; i < 10; i++)
            {
                var testModel = new TestModel
                {
                    Id = i,
                    Name = $"Nummero {i}",
                    IsComplete = true

                };

                testList.Add(testModel);
            }
            return testList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public TestModel Get(int id)
        {
            return new TestModel
            {
                Id = id,
                Name = $"Nummero {id}",
                IsComplete = true

            }; ;
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
    }
}
