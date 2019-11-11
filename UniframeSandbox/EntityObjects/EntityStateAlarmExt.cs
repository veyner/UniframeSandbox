using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateAlarmExt
    {
        public Guid AlarmId { get; set; }
        public string Name { get; set; }
        public string AlarmType { get; set; }
        public CurrentAlarmState AlarmState { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string SourceName { get; set; }
        public string Note { get; set; }

        public Guid FacilityId { get; set; }
        public EntityFacility Facility { get; set; }

        public enum CurrentAlarmState
        {
            New,
            Confirmed,
            Closed
        }
    }
}
