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
    public class StateController : ControllerBase
    {
        private FacilityContext _db;
        private ConverterEntityToView _converter;
        public StateController(FacilityContext context)
        {
            _db = context;
            _converter = new ConverterEntityToView();
        }
        // GET: api/State
        [HttpGet]
        public IActionResult Get()
        {
            var stateList = _db.States
                .Include(x => x.Common)
                .Include(x => x.Connection)
                .Include(x => x.Alarm)
                .Include(x => x.System)
                .Include(x => x.Parameters)
                .Include(x => x.Device);
            var viewList = stateList.Select(x => _converter.ConvertState(x));
            return Ok(viewList);
        }

        // GET: api/State/FacilityId/commonExt
        [HttpGet("{id}/commonExt")]
        public IActionResult GetStateCommonExt(Guid id)
        {
            var currentState = _db.StateCommonsExt
                .SingleOrDefault(x => x.FacilityId == id);
            var viewCommon = _converter.ConvertExtCommon(currentState);
            return Ok(viewCommon);
        }

        // GET: api/State/FacilityId/alarmExt
        [HttpGet("{id}/alarmExt")]
        public IActionResult GetStateAlarmExt(Guid id)
        {
            var currentFacilityAlarms = _db.StateAlarmsExt
                .Where(x => x.FacilityId == id);
            var viewAlarms = currentFacilityAlarms.Select(x => _converter.ConvertExtAlarm(x)).ToList();
            return Ok(viewAlarms);
        }

        // GET: api/State/FacilityId/deviceExt
        [HttpGet("{id}/deviceExt")]
        public IActionResult GetStateDeviceExt(Guid id)
        {
            var currentFacilityDevices = _db.StateDevicesExt
                .Where(x => x.FacilityId == id);
            var viewDevices = currentFacilityDevices.Select(x => _converter.ConvertExtDevice(x)).ToList();
            return Ok(viewDevices);
        }

        // GET: api/State/FacilityId/connectionExt
        [HttpGet("{id}/connectionExt")]
        public IActionResult GetStateConnectionExt(Guid id)
        {
            var currentFacilityConnections = _db.StateConnectionsExt
                .Where(x => x.FacilityId == id);
            var viewConnections = currentFacilityConnections.Select(x => _converter.ConvertExtConnection(x)).ToList();
            return Ok(viewConnections);
        }

        // GET: api/State/FacilityId/systemExt
        [HttpGet("{id}/systemExt")]
        public IActionResult GetStateSystemExt(Guid id)
        {
            var currentFacilitySystems = _db.StateSystemsExt
                .Where(x => x.FacilityId == id);
            var viewSystems = currentFacilitySystems.Select(x => _converter.ConvertExtSystem(x)).ToList();
            return Ok(viewSystems);
        }
        // POST: api/State
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/State/5
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
