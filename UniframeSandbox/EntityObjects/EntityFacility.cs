using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityFacility
    {
        public Guid FacilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CoordinatesId { get; set; }
        public EntityCoordinates Coordinates { get; set; }
        //public EntityFacilityCoordinate FacilityCoordinates { get; set; }

    }
}
