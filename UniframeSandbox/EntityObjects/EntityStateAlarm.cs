using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateAlarm
    {
        public Guid AlarmId { get; set; }
        public int ActiveAlarmCount { get; set; }
        public DateTime LastActiveAlarmDate { get; set; }
        public string Note { get; set; }

        public Guid StateId { get; set; }
        public EntityFacilityState State { get; set; }
    }
}
