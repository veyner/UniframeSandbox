using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateConnection
    {
        public Guid ConnectionId { get; set; }
        public ConnectionState CurrentConnectionState { get; set; }
        public string Note { get; set; }
        public DateTime LastActivityDate { get; set; }

        public Guid StateId { get; set; }
        public EntityFacilityState State{ get; set; }

        public enum ConnectionState
        {
            unknown,
            online,
            offline
        }
    }
}
