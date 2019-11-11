using System;

namespace UniframeSandbox.EntityObjects
{
    public class EntityStateFacilityParameter
    {
        public Guid StateFacilityParamId { get; set; }
        public string Key { get; set; }
        public string KeyName { get; set; }
        public string Value { get; set; }
        public string ValueName { get; set; }
        public DateTime ParameterAtDate { get; set; }
        public string Note { get; set; }

        public Guid StateId { get; set; }
        public EntityFacilityState State { get; set; }
    }
}
