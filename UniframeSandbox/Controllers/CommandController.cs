﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UniframeSandbox.EntityObjects;
using UniframeSandbox.ViewObjects;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniframeSandbox.Controllers
{
    [Route("api/[controller]")]
    public class CommandController : Controller
    {
        private FacilityContext _db;
        public CommandController(FacilityContext facilityContext)
        {
            _db = facilityContext;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] ViewExecCommand currentExecCommand)
        {
            var currentCommand = _db.FacilityCommands.SingleOrDefault(x => x.CommandId == currentExecCommand.CommandId && x.FacilityId == currentExecCommand.FacilityId);
            if(currentCommand == null)
            {
                return NotFound("Команда не выполнена");
            }
            return Ok("Команда выполнена");
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
