using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateConnectionExt
    {
        public Guid ConnectionID { get; set; }
        public ConnectionState CurrentConnectionState { get; set; }
        public string Note { get; set; }
        public DateTime LastActivityDate { get; set; }

        public Guid FacilityId { get; set; }
        public EntityFacility Facility { get; set; }

        public enum ConnectionState
        {
            unknown,
            online,
            offline
        }
    }
}
