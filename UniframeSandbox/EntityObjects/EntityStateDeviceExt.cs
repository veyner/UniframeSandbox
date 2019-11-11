using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateDeviceExt
    {
        public Guid StateDeviceId { get; set; }

        public string Name { get; set; }
        public string Note { get; set; }

        public Guid FacilityId { get; set; }
        public EntityFacility Facility { get; set; }

    }
}
