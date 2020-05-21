﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OperationController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public double GetSun(int a,int b)
        {
            return a + b;
        }
        [HttpGet]
        public double GetSot(int a, int b)
        {
            return a - b;
        }
        [HttpGet]
        public double GetProduct(int a, int b)
        {
            return a * b;
        }
        [HttpGet]
        public double GetDiv(int a, int b)
        {
            return a / b;
        }
        [HttpGet]
        public double GetMedia(int a, int b,int c,int d)
        {
            return (a+b+c+d)/4;
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
