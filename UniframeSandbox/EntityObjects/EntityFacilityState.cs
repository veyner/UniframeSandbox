using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityFacilityState
    {
        public Guid StateId { get; set; }
        public EntityStateCommon Common { get; set; }
        public EntityStateConnection Connection { get; set; }
        public EntityStateAlarm Alarm { get; set; }
        public EntityStateSystem System { get; set; }
        public EntityStateDevice Device { get; set; }
        public List<EntityStateFacilityParameter> Parameters { get; set; }

        public Guid FacilityID { get; set; }
        public EntityFacility Facility { get; set; }


    }
}
