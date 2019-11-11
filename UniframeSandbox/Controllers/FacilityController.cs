using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniframeSandbox.EntityObjects;
using UniframeSandbox.ViewObjects;

namespace UniframeSandbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private FacilityContext _db;
        private ConverterEntityToView _converter;
        public FacilityController(FacilityContext facilityContext)
        {
            _db = facilityContext;
            _converter = new ConverterEntityToView();
        }
        // GET: api/Facility
        [HttpGet]
        public IEnumerable<ViewFacility> Get()
        {
            var facilities = _db.Facilities.ToList();
            var coords = _db.Coordinates.ToList();
            var list = facilities
                .Select(x => _converter.ConvertFacility(x,_db.Coordinates.SingleOrDefault(c => c.CoordinatesId == x.CoordinatesId)));
            return list;
        }

        // GET: api/Facility/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var fac = _db.Facilities
                        .SingleOrDefault(x => x.FacilityId == id);
            if (fac == null)
            {
                return NotFound();
            }
            var coords = _db.Coordinates
                        .SingleOrDefault(x => x.CoordinatesId == fac.CoordinatesId);
            var currentViewFacility = _converter.ConvertFacility(fac,coords);
            return Ok(currentViewFacility);
        }

        [HttpGet("{id}/commands")]
        public IActionResult GetCommands(Guid id)
        {
            var facilityCommands = _db.FacilityCommands.Where(x => x.FacilityId == id);
            if(facilityCommands == null)
            {
                return NotFound();
            }
            var viewCommands = facilityCommands.Select(x => _converter.ConvertCommand(x)).ToList();
            return Ok(viewCommands);
        }

        // POST: api/Facility
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT: api/Facility/5
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
