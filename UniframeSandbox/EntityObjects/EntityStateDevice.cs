using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateDevice
    {
        public Guid StateDeviceId { get; set; }

        public string Note { get; set; }
        public int TotatDevicesCount { get; set; }
        public int OnlineDevicesCount { get; set; }
        public int DevicesInAlarmStateCount { get; set; }

        public Guid StateId { get; set; }
        public EntityFacilityState State { get; set; }

   

    }
}
