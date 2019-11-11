using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateSystem
    {
        public Guid StateSystemId { get; set; }
        public string Note { get; set; }
        public int TotalSystemsCount { get; set; }
        public int ActiveSystemsCount { get; set; }

        public Guid StateId { get; set; }
        public EntityFacilityState State { get; set; }
    }
}
