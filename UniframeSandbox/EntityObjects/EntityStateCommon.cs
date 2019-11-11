using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateCommon
    {
        public Guid StateCommonId { get; set; }
        public CurrentCommonState Current { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime StateAtDate { get; set; }

        public Guid StateId { get; set; }
        public EntityFacilityState State { get; set; }

        public enum CurrentCommonState
        {
            normal,
            warning,
            critical
        }
    }
}
