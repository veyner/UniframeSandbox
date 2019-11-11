using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateCommonExt
    {
        public Guid StateCommonId { get; set; }
        public CurrentCommonState Current { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime StateAtDate { get; set; }

        public Guid FacilityId { get; set; }
        public EntityFacility Facility { get; set; }

        public enum CurrentCommonState
        {
            normal,
            warning,
            critical
        }
    }
}
